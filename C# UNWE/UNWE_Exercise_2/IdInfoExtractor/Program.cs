using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdInfoExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your ID number");
                string HumanID = Console.ReadLine();
                Console.WriteLine();
                //HumanID = "9202207665";

                if (IsValidID(HumanID))
                {
                    Console.WriteLine(ExtractInfo(HumanID));
                }
            }
            
            catch (Exception e)
            {
                Console.WriteLine("***INVALID ID NUMBER***");
                Console.WriteLine(e.GetBaseException().Message);
            }
               
        }

        private static string ExtractInfo(string ID)
        {
            StringBuilder IdInfo = new StringBuilder();

            //Extract gender
            if (int.Parse(ID[8].ToString()) % 2 == 0)
            {
                IdInfo.AppendFormat("Gender: Male \n");
            }
            else
            {
                IdInfo.AppendFormat("Gender: Woman \n");
            }
            
            //Get Year of birth
            int DayDigit = int.Parse(ID.Substring(4, 2));
            int MonthDigit = int.Parse(ID.Substring(2, 2));
            int YearDigit = int.Parse(ID.Substring(0, 2));
            int YearOfBirth = 0;
            if (MonthDigit > 20 && MonthDigit < 33)
            {
                YearOfBirth = 1800 + YearDigit;
            }
            else if (MonthDigit > 40)
            {
                YearOfBirth = 2000 + YearDigit;
            }
            else
            {
                YearOfBirth = 1900 + YearDigit;
            }

            //Get years and days to next birthday
            DateTime Birthday = new DateTime(YearOfBirth, MonthDigit, DayDigit);
            DateTime ThisYearBirthDay = new DateTime(DateTime.Now.Year,MonthDigit,DayDigit);

            int Years = DateTime.Now.Year - Birthday.Year;
            int DaysToBirthDay = (ThisYearBirthDay - DateTime.Now).Days;

            if (DateTime.Now < ThisYearBirthDay)
            {
                Years--;
            }
            else
            {
                DaysToBirthDay = (ThisYearBirthDay.AddYears(1) - DateTime.Now).Days;
            }
           
            IdInfo.AppendFormat("Years: {0} \n", Years);
            IdInfo.AppendFormat("Birthday date: {0} \n", Birthday.ToShortDateString());
            IdInfo.AppendFormat("Days to next Birthday: {0} \n", DaysToBirthDay);

            return IdInfo.ToString();
        }

        static bool IsValidID(string ID)
        {
            if (ID.Length != 10)
            {
                throw new ArgumentException("Invalid ID length !");
            }

            int YearDigit = int.Parse(ID.Substring(0, 2));
            if (YearDigit < 0)
            {
                throw new ArgumentException("Invalid ID year !");
            }

            int MonthDigit = int.Parse(ID.Substring(2, 2));
            if (MonthDigit > 52 || MonthDigit < 1)
            {
                throw new ArgumentException("Invalid ID month !");
            }

            int DayDigit = int.Parse(ID.Substring(4, 2));
            if (DayDigit > 31 || DayDigit < 1)
            {
                throw new ArgumentException("Invalid ID day !");
            }

            // Validate last digit
            int LastDigit = int.Parse(ID.Substring(9));
            int[] DigitWeights = {2,4,8,5,10,9,7,3,6};
            int SumWeights = 0;
            for (int i = 0; i < DigitWeights.Length; i++)
            {
                int CurrentDigit= int.Parse(ID[i].ToString());
                SumWeights += CurrentDigit * DigitWeights[i];
            }

            if (SumWeights % 11 < 10 && LastDigit != SumWeights % 11 || 
                SumWeights % 11 > 10 && LastDigit != 0)
            {
                throw new ArgumentException("Invalid last ID digit !");
            }

            return true;
        }
    }
}

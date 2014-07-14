using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClasses
{
    class GSMCallHistoryTest
    {
        private static MobilePhone Phone = new MobilePhone("GalaxyNote2", "Samsung", 1200, "Alexander", new Battery("Samsung", 200, 50, BatteryType.LiIon), new Display(5.5, 10000000));
        private const decimal PricePerMinute = 0.37M;

        //Constructor
        static GSMCallHistoryTest()
        {
            Phone.AddCall(new Call("0888999777", 100));
            Phone.AddCall(new Call("0888777666", 120));
            Phone.AddCall(new Call("0888666555", 150));
            Phone.AddCall(new Call("0888555444", 200));
            Phone.AddCall(new Call("0888444333", 500));
        }

        //Methods
        public static void Run()
        {
            Console.WriteLine("\n*** Call history test ***\n");
            //Print calls
            foreach (var call in Phone.CallHistory)
            {
                Console.WriteLine(call);
            }

            decimal TotalPriceOfCalls = Phone.GetTotalPriceOfCalls(PricePerMinute);
            Console.WriteLine("The total price of calls is: {0}", TotalPriceOfCalls);
            
            //Find number of longest call
            int LongestCall = 0;
            string DialedNum = "";
            for (int i = 0; i < Phone.CallHistory.Count; i++)
            {
                if (Phone.CallHistory[i].DurationInSec > LongestCall)
                {
                    LongestCall = Phone.CallHistory[i].DurationInSec;
                    DialedNum = Phone.CallHistory[i].PhoneNumber;
                }       
            }

            //Remove longest call number
            Console.WriteLine("\nRemove longest call...\n");
            Phone.DeleteCallBy(DialedNum);

            TotalPriceOfCalls = Phone.GetTotalPriceOfCalls(PricePerMinute);
            Console.WriteLine("The total price of calls is: {0}", TotalPriceOfCalls);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ReadsAndPrintsCompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read Company data
            Console.WriteLine("Company data");
            Console.Write("Please enter Company name: ");
            string CompanyName = Console.ReadLine();
            Console.Write("Please enter Company Address: ");
            string CompanyAddress = Console.ReadLine();
            Console.Write("Please enter Company Phone number: ");
            string CompanyPhone = Console.ReadLine();
            Console.Write("Please enter Company Fax number: ");
            string CompanyFax = Console.ReadLine();
            Console.Write("Please enter Company Web site: ");
            string CompanyWebSite = Console.ReadLine();

            //Read Manager data
            Console.WriteLine("Manager data");
            Console.Write("Please enter Manager First name: ");
            string ManagerFirstName = Console.ReadLine();
            Console.Write("Please enter Manager Last name: ");
            string ManagerLastName = Console.ReadLine();
            Console.Write("Please enter Manager Age: ");
            string ManagerAge = Console.ReadLine();
            Console.Write("Please enter Manager Phone number: ");
            string ManagerPhone = Console.ReadLine();
            Console.WriteLine();

            //Printing all data
            Console.WriteLine("Company data");
            Console.WriteLine("Company name: {0}", CompanyName);
            Console.WriteLine("Company Address: {0}", CompanyAddress);
            Console.WriteLine("Company Phone number: {0}", CompanyPhone);
            Console.WriteLine("Company Fax number: {0}", CompanyFax);
            Console.WriteLine("Company Web site: {0}", CompanyWebSite);

            Console.WriteLine("Manager data");
            Console.WriteLine("Manager First name: {0}", ManagerFirstName);
            Console.WriteLine("Manager Last name: {0}", ManagerLastName);
            Console.WriteLine("Manager Age: {0}", ManagerAge);
            Console.WriteLine("Manager Phone number: {0}", ManagerPhone);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClasses
{
    class MobilePhoneTest
    {
        private static MobilePhone FirstPhone = new MobilePhone("Desire HD", "HTC", 1000, "Niks", new Battery("Toshiba", 90, 5, BatteryType.LiIon), new Display(4.5, 100000));
        private static MobilePhone SecondPhone = new MobilePhone("Galaxy", "Samsung", 1100, "Lyubo", new Battery("Samsung", 100, 2, BatteryType.LiIon), new Display(4.8, 1000000));
        private static MobilePhone ThirthPhone = new MobilePhone("GalaxyNote2", "Samsung", 1200, "Alexander", new Battery("Samsung", 200, 50, BatteryType.LiIon), new Display(5.5, 10000000));
        private static MobilePhone FourthPhone = new MobilePhone("LUMIA: 900", "Nokia", 999, "Alexander", new Battery("Duracell", 50, 10, BatteryType.LiIon), new Display(5.5, 65000));
        public static void Run()
        {
            Console.WriteLine("\n*** MobilePhone Class test ***\n");
            MobilePhone[] MobilePhones = { FirstPhone, SecondPhone, ThirthPhone, FourthPhone };

            //Printing info of all phones
            foreach (var phone in MobilePhones)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(MobilePhone.IPhone4S);
        }
    }
}

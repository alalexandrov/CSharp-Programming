using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClasses
{
    class MobilePhone
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        private static MobilePhone iPhone4S = new MobilePhone("Iphone 4S", "Apple", 1000, "Alexander",
            new Battery("LG", 600, 200, BatteryType.LiIon), new Display(5.6, 1000000));

        //Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length > 2 && value.Length < 20)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("The name of phone model must be between 2 and 20 characters !");
                }
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length > 2 && value.Length < 20)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("The name of phone manufacturer must be between 2 and 20 characters !");
                }
            }
        }
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0 && value < 10000)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The price of phone must be in range 0 and 10 000 !");
                }
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length > 2 && value.Length < 20)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("The name of phone owner must be between 2 and 20 characters !");
                }
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }
        public static MobilePhone IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        //Constructors
        public MobilePhone(string model, string manufacturer,
            decimal? price = null, string owner = null,
            Battery battery = null, Display display = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        //Override ToString method
        public override string ToString()
        {
            return string.Format("Phone model: {0}\n" +
               "Manufacturer: {1}\n" +
               "Price: {2}\n" +
               "Owner: {3}\n" +
               "Battery: {4}\n" +
               "Display: {5} inch.\n", this.model, this.manufacturer, this.price, this.owner, this.battery.Model, this.display.Size);
        }

        //Methods
        public void AddCall(Call call)
        {
            if (call != null)
            {
                this.callHistory.Add(call);
            }
            else
            {
                throw new ArgumentException("Call can't be null value !");
            }
        }
        public void DeleteCallBy(string DialedPhone)
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (this.callHistory[i].PhoneNumber == DialedPhone)
                {
                    this.callHistory.RemoveAt(i);
                }
            }
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal GetTotalPriceOfCalls(decimal PricePerMinute)
        {
            decimal Total = 0;
            foreach (var call in this.callHistory)
            {
                Total += call.DurationInSec * (PricePerMinute / 60);
            }

            return Math.Round(Total,2);
        }
    }
}

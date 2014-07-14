using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClasses
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    class Battery
    {
        string model;
        int hoursIdle;
        int hoursTalk;
        BatteryType type;

        //Properties 
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != null && (value.Length > 0 && value.Length < 20))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Invalid battery model !");
                }
            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value > 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException("Invalid value for hours in idle !");
                }
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException("Invalid value for talk hours !");
                }
            }
        }
        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        //Costructors
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }
    }
}

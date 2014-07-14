using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClasses
{
    class Display
    {
        double size = 0;
        int numOfColors = 0;

        //Properties
        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException("Invalid size of display !");
                }
            }
        }
        public int NumOfColors
        {
            get
            {
                return this.numOfColors;
            }
            set
            {
                if (value > 0 )
                {
                    this.numOfColors = value;
                }
                else
                {
                    throw new ArgumentException("Invalid number of colors !");
                }
            }
        }

        //Contructors
        public Display(double size, int numOfColors)
        {
            this.Size = size;
            this.NumOfColors = numOfColors;
        }
    }
}

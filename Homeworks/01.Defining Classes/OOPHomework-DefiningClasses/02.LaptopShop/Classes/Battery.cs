using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.LaptopShop.Classes
{
    class Battery
    {
        private String _batteryInfo;
        private double _batteryLife;

        public Battery()
            : this("Not Provided", 0)
        {

        }

        public Battery(String batteryInfo)
            : this(batteryInfo, 0)
        {

        }

        public Battery(double batteryLife)
            : this("Not Provided", batteryLife)
        {

        }

        public Battery(String batteryInfo, double batteryLife)
        {
            this.BatteryInfo = batteryInfo;
            this.BatteryLifeHours = batteryLife;
        }

        public String BatteryInfo
        {
            set
            {
                CheckIfValid(value, "Battery Info can't be NULL or Empty");
                this._batteryInfo = value;
            }
            get
            {
                return this._batteryInfo;
            }
        }

        public double BatteryLifeHours
        {
            set
            {
                CheckIfValid(value, "Battery Life can't be < 0");
                this._batteryLife = value;
            }
            get
            {
                return this._batteryLife;
            }
        }

        public override string ToString()
        {
            return String.Format("Battery: {0}\n" +
                                "Battery Life: {1}\n",
                                this.BatteryInfo, this.BatteryLifeHours);
        }

        private void CheckIfValid(String value, String message)
        {
            if (value == null)
            {
                throw new ArgumentException(message);
            }

            value = Regex.Replace(value, @"\s{2,}", " ");
            if (value == "" || value == " ")
            {
                throw new ArgumentException(message);
            }
        }

        private void CheckIfValid(double value, String message)
        {
            if (value < 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.LaptopShop.Classes
{
    class Laptop
    {
        private String _model;
        private String _manufacturer;
        private String _processor;
        private int _ram;
        private String _gfx;
        private String _hdd;
        private String _screen;
        private decimal _price;
        private Battery _battery;

        public Laptop(String model, decimal price)
            : this(model, price, "Not Provided", "Not Provided", 0, "Not Provided", "Not Provided", "Not Provided",
                   "Not Provided", 0d)
        {

        }

        public Laptop(String model, decimal price, String manufacturer, String processor,
            int ram, String gfx, String hdd, String screen, String batteryInfo, double batteryLifeHours)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Gfx = gfx;
            this.Hdd = hdd;
            this.Screen = screen;
            this._battery = new Battery(batteryInfo, batteryLifeHours);
        }

        public String Model
        {
            set
            {
                CheckIfValid(value, "Model can't be NUll or Empty");
                this._model = value;
            }
            get
            {
                return this._model;
            }
        }

        public decimal Price
        {
            set
            {
                CheckIfValid(value, "Price can't be < 0");
                this._price = value;
            }
            get
            {
                return this._price;
            }
        }

        public String Manufacturer
        {
            set
            {
                CheckIfValid(value, "Manufacturer can't be NUll or Empty");
                this._manufacturer = value;
            }
            get
            {
                return this._manufacturer;
            }
        }

        public String Processor
        {
            set
            {
                CheckIfValid(value, "Processor can't be Null or Empty");
                this._processor = value;
            }
            get
            {
                return this._processor;
            }
        }

        public int Ram
        {
            set
            {
                CheckIfValid(value, "Ram can't be < 0");
                this._ram = value;
            }
            get
            {
                return this._ram;
            }
        }

        public String Gfx
        {
            set
            {
                CheckIfValid(value, "GFX can't be Null or Empty");
                this._gfx = value;
            }
            get
            {
                return this._gfx;
            }
        }

        public String Hdd
        {
            set
            {
                CheckIfValid(value, "Hdd can't be NUll or empty");
                this._hdd = value;
            }
            get
            {
                return this._hdd;
            }
        }

        public String Screen
        {
            set
            {
                CheckIfValid(value, "Screen can't be null or empty");
                this._screen = value;
            }
            get
            {
                return this._screen;
            }
        }

        public String BatteryInfo
        {
            set
            {
                if (this._battery == null)
                {
                    this._battery = new Battery(value);
                }
                else
                {
                    this._battery.BatteryInfo = value;
                }
            }
            get
            {
                return this._battery.BatteryInfo;
            }
        }

        public double BatteryLifeHours
        {
            set
            {
                if (this._battery == null)
                {
                    this._battery = new Battery(value);
                }
                else
                {
                    this._battery.BatteryLifeHours = value;
                }
            }
            get
            {
                return this._battery.BatteryLifeHours;
            }
        }

        public override string ToString()
        {
            return String.Format("Model: {0}\n" +
                                "Manufacturer: {1}\n" +
                                "Processor: {2}\n" +
                                "RAM: {3} GB\n" +
                                "GFX: {4}\n" +
                                "HDD: {5}\n" +
                                "Screen: {6}\n" +
                                "{7}" +
                                "Price: {8} lv.\n",
                                this.Model, this.Manufacturer, this.Processor, this.Ram,
                                this.Gfx, this.Hdd, this.Screen, this._battery.ToString(),
                                this.Price);
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

        private void CheckIfValid(decimal value, String message)
        {
            if (value < 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}

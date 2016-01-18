using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.LaptopShop.Classes;

namespace _02.LaptopShop
{
    class LaptopShop
    {
        private static Laptop _laptop;
        private static String MODEL = "Lenovo Yoga 2 Pro";
        private static String MANUFACTURER = "Lenovo";
        private static String PROCESSOR = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
        private static int RAM = 8;
        private static String GFX = "Intel HD Graphics 4400";
        private static String HDD = "128GB SSD";
        private static String SCREEN = @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display";
        private static decimal PRICE = 2259.00m;
        private static String BATTERY_INFO = "Li-Ion, 4-cells, 2550 mAh";
        private static double BATTERY_LIFE_HOURS = 4.5d;

        static void Main(string[] args)
        {
            //Check Constructors
            //Full laptop
            _laptop = new Laptop(MODEL, PRICE, MANUFACTURER, PROCESSOR, RAM, GFX, HDD,
                SCREEN, BATTERY_INFO, BATTERY_LIFE_HOURS);
            Console.WriteLine("TEST 1\n" + _laptop.ToString());

            //Mandatory Only
            _laptop = new Laptop(MODEL, PRICE);
            Console.WriteLine("TEST 2\n" + _laptop.ToString());

            //Try Invalid Model
            try
            {
                _laptop.Model = null;
            }
            catch (ArgumentException)
            {
                try
                {
                    _laptop.Model = " ";
                }
                catch (ArgumentException)
                {
                    try
                    {
                        _laptop.Model = "";
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine("TEST 3\n" + ae.Message);
                    }
                }
            }

            //Try Invalid Price
            try
            {
                _laptop.Price = -1;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 4\n" + ae.Message);
            }

            //Try Invalid manufacturer
            try
            {
                _laptop.Manufacturer = null;
            }
            catch (ArgumentException)
            {
                try
                {
                    _laptop.Manufacturer = " ";
                }
                catch (ArgumentException)
                {
                    try
                    {
                        _laptop.Manufacturer = "";
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine("TEST 5\n" + ae.Message);
                    }
                }
            }

            //Try Invalid Processor
            try
            {
                _laptop.Processor = null;
            }
            catch (ArgumentException)
            {
                try
                {
                    _laptop.Processor = " ";
                }
                catch (ArgumentException)
                {
                    try
                    {
                        _laptop.Processor = "";
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine("TEST 6\n" + ae.Message);
                    }
                }
            }

            //Try Invalid RAM
            try
            {
                _laptop.Ram = -1;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 7\n" + ae.Message);
            }

            //Try Invalid GFX
            try
            {
                _laptop.Gfx = null;
            }
            catch (ArgumentException)
            {
                try
                {
                    _laptop.Gfx = " ";
                }
                catch (ArgumentException)
                {
                    try
                    {
                        _laptop.Gfx = "";
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine("TEST 8\n" + ae.Message);
                    }
                }
            }

            //Try Invalid HDD
            try
            {
                _laptop.Hdd = null;
            }
            catch (ArgumentException)
            {
                try
                {
                    _laptop.Hdd = " ";
                }
                catch (ArgumentException)
                {
                    try
                    {
                        _laptop.Hdd = "";
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine("TEST 9\n" + ae.Message);
                    }
                }
            }

            //Try Invalid Screen
            try
            {
                _laptop.Screen = null;
            }
            catch (ArgumentException)
            {
                try
                {
                    _laptop.Screen = " ";
                }
                catch (ArgumentException)
                {
                    try
                    {
                        _laptop.Screen = "";
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine("TEST 10\n" + ae.Message);
                    }
                }
            }

            //Try Invalid Battery Info
            try
            {
                _laptop.BatteryInfo = null;
            }
            catch (ArgumentException)
            {
                try
                {
                    _laptop.BatteryInfo = " ";
                }
                catch (ArgumentException)
                {
                    try
                    {
                        _laptop.BatteryInfo = "";
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine("TEST 11\n" + ae.Message);
                    }
                }
            }

            //Try Invalid Battery Life
            try
            {
                _laptop.BatteryLifeHours = -1;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("TEST 12\n" + ae.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.GalacticGPS.Enums;

namespace _01.GalacticGPS.Structs
{
    public struct Location
    {
        private double _latitude;
        private double _longitude;
        private Planet _planet { set; get; }

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this._planet = planet;
        }

        public double Latitude
        {
            set
            {
                this.ValidateData(value, -90, 90, "Latitude must be between -90 and 90");
                this._latitude = value;
            }
            get
            {
                return this._latitude;
            }
        }

        public double Longitude
        {
            set
            {
                this.ValidateData(value, -180, 180, "Longitude must be between -180 and 180");
                this._longitude = value;
            }
            get
            {
                return this._longitude;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}",
                this.Latitude, this.Longitude, this._planet);
        }

        private void ValidateData(double value, double min, double max, String message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}

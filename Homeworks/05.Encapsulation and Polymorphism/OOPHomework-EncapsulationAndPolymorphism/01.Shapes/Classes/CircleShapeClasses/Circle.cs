using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Classes.CircleShapeClasses
{
    class Circle : IShape
    {
        private double _radios;

        public Circle()
            : this(0d)
        {

        }

        public Circle(double radios)
        {
            this.Radios = radios;
        }

        public double CalculateArea()
        {
            return 3.14d * (Math.Pow(this.Radios, 2));
        }

        public double CalculatePerimeter()
        {
            return 2d * 3.14d * this.Radios;
        } 

        public double Radios
        {
            set
            {
                this._radios = value;
            }
            get
            {
                return this._radios;
            }
        }
    }
}

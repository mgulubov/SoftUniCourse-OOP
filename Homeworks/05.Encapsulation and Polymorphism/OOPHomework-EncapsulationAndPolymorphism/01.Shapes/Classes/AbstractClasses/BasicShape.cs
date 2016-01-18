using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Classes.AbstractClasses
{
    abstract class BasicShape : IShape
    {
        private double _width;
        private double _height;

        public BasicShape()
        {

        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public double Width
        {
            set
            {
                this._width = value;
            }
            get
            {
                return this._width;
            }
        }

        public double Height
        {
            set
            {
                this._height = value;
            }
            get
            {
                return this._height;
            }
        }
    }
}

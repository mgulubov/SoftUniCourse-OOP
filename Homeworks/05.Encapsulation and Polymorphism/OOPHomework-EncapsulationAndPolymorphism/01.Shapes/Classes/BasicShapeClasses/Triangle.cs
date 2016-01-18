using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Classes.AbstractClasses;

namespace _01.Shapes.Classes.BasicShapeClasses
{
    class Triangle : BasicShape
    {
        public Triangle()
            : this(0d, 0d)
        {

        }

        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 3;
        }
    }
}

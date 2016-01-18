using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Classes.AbstractClasses;

namespace _01.Shapes.Classes.BasicShapeClasses
{
    class Rectangle : BasicShape
    {
        public Rectangle()
            : this(0d, 0d)
        {

        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.Width + this.Height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Classes.CircleShapeClasses;

namespace _01.Shapes.Classes.FactoryClasses
{
    class CircleShapeFactory
    {
        public static readonly CircleShapeFactory CIRCLE_SHAPE_FACTORY = new CircleShapeFactory();

        private CircleShapeFactory()
        {
            //private constructor
        }

        public Circle CreateCircleShape(String circleShape)
        {
            return CreateCircleShape(circleShape, 0d);
        }

        public Circle CreateCircleShape(String circleShape, double radios)
        {
            switch (circleShape)
            {
                case "circle":
                    return new Circle(radios);
                default:
                    throw new ArgumentException("{0} is not a valid circle shape");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Classes.AbstractClasses;
using _01.Shapes.Classes.BasicShapeClasses;

namespace _01.Shapes.Classes.FactoryClasses
{
    class BasicShapeFactory
    {
        public static readonly BasicShapeFactory BASIC_SHAPE_FACTORY = new BasicShapeFactory();

        private BasicShapeFactory()
        {
            //private constructor
        }

        public BasicShape CreateBasicShape(String basicShape)
        {
            return CreateBasicShape(basicShape, 0d, 0d);
        }

        public BasicShape CreateBasicShape(String basicShape, double width, double height)
        {
            switch (basicShape)
            {
                case "rectangle":
                    return new Rectangle(width, height);
                case "triangle":
                    return new Triangle(width, height);
                default:
                    throw new ArgumentException("{0} is not a supported shape", basicShape);
            }
        }
    }
}

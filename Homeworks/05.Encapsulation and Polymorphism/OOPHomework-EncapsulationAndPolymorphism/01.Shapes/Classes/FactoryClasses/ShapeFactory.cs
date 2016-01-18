using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;
using _01.Shapes.Classes.BasicShapeClasses;
using _01.Shapes.Classes.CircleShapeClasses;
using _01.Shapes.Classes.FactoryClasses;

namespace _01.Shapes.Classes.FactoryClasses
{
    class ShapeFactory
    {
        public static readonly ShapeFactory SHAPE_FACTORY = new ShapeFactory();
        private BasicShapeFactory _basicShapes = BasicShapeFactory.BASIC_SHAPE_FACTORY;
        private CircleShapeFactory _circleShapes = CircleShapeFactory.CIRCLE_SHAPE_FACTORY;

        private ShapeFactory()
        {
            //private constructor
        }

        public IShape CreateBasicShape(String shapeType)
        {
            return this._basicShapes.CreateBasicShape(shapeType);
        }

        public IShape CreateBasicShape(String shapeType, double width, double height)
        {
            return this._basicShapes.CreateBasicShape(shapeType, width, height);
        }

        public IShape CreateCircleShape(String shapeType)
        {
            return this._circleShapes.CreateCircleShape(shapeType);
        }

        public IShape CreateCircleShape(String shapeType, double radios)
        {
            return this._circleShapes.CreateCircleShape(shapeType, radios);
        }
    }
}

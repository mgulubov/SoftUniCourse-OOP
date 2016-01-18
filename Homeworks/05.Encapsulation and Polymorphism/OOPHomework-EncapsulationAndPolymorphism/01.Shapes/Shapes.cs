using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;
using _01.Shapes.Classes.FactoryClasses;

namespace _01.Shapes
{
    class Shapes
    {
        private static List<IShape> _shapesList;
        private static ShapeFactory _shapesFactory = ShapeFactory.SHAPE_FACTORY;

        static void Main(string[] args)
        {
            _shapesList = new List<IShape>();

            PopulateShapesList();

            CalculateAreas();
            CalculatePerimeter();
        }

        private static void CalculateAreas()
        {
            foreach (IShape shape in _shapesList)
            {
                Console.WriteLine(shape.CalculateArea());
            }
        }

        private static void CalculatePerimeter()
        {
            foreach (IShape shape in _shapesList)
            {
                Console.WriteLine(shape.CalculatePerimeter());
            }
        }

        private static void PopulateShapesList()
        {
            _shapesList.Clear();
            try
            {
                _shapesList.Add(_shapesFactory.CreateBasicShape("rectangle"));
                _shapesList.Add(_shapesFactory.CreateBasicShape("triangle"));
                _shapesList.Add(_shapesFactory.CreateCircleShape("circle"));
                _shapesList.Add(_shapesFactory.CreateBasicShape("rectangle", 13, 90));
                _shapesList.Add(_shapesFactory.CreateBasicShape("triangle", 58, 1));
                _shapesList.Add(_shapesFactory.CreateCircleShape("circle", 13));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                PopulateShapesList();
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.ProblemPoint3D.Classes;

namespace _03.ProblemPaths.Classes
{
    class Path3D
    {
        private List<Point3D> _pointsList;

        public Path3D()
        {
            this._pointsList = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            if (point == null)
            {
                throw new ArgumentNullException("Point can't be null");
            }

            this._pointsList.Add(point);
        }

        public Point3D GetPointAtIndex(int index)
        {
            try
            {
                return this._pointsList[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new ArgumentException("Provided index " + index + " is not within the pointsList bounds");
            }
        }

        public int GetNumberOfPoints()
        {
            return this._pointsList.Count;
        }
    }
}

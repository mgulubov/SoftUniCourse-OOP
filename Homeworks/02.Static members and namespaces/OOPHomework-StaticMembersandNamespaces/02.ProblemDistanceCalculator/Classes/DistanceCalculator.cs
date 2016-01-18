using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.ProblemPoint3D.Classes;

namespace _02.ProblemDistanceCalculator.Classes
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D pointA, Point3D pointB)
        {
            double distance = Math.Sqrt(
                    Math.Pow(pointA.CurrentPosition[0] - pointB.CurrentPosition[0], 2)
                    +
                    Math.Pow(pointA.CurrentPosition[1] - pointB.CurrentPosition[1], 2)
                    +
                    Math.Pow(pointA.CurrentPosition[2] - pointB.CurrentPosition[2], 2)
                );

            return distance;
        }
    }
}

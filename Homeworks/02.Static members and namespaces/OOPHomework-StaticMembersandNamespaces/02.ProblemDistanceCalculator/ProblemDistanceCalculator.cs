using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.ProblemPoint3D.Classes;
using _02.ProblemDistanceCalculator.Classes;

namespace _02.ProblemDistanceCalculator
{
    class ProblemDistanceCalculator
    {
        static void Main(string[] args)
        {
            Point3D pointA = new Point3D(new int[] { 1, 3, 5 });
            Point3D pointB = new Point3D(new int[] { 2, 4, 6 });

            double distance = DistanceCalculator.CalculateDistance(pointA, pointB);

            Console.WriteLine(distance);
        }
    }
}

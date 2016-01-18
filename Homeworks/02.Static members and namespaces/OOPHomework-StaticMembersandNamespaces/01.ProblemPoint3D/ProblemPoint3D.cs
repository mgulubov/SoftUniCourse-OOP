using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.ProblemPoint3D.Classes;

namespace _01.ProblemPoint3D
{
    class ProblemPoint3D
    {
        static void Main(string[] args)
        {
            int[] p = Point3D.StartingPosition;

            Console.WriteLine("{0}", string.Join(", ", p));

        }
    }
}

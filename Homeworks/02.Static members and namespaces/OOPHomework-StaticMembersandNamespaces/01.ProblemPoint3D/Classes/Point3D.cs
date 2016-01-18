using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProblemPoint3D.Classes
{
    public class Point3D
    {
        private static readonly int[] STARTING_POINT = new int[] {0, 0, 0};
        private int[] _currentPosition;

        public Point3D()
            : this(STARTING_POINT)
        {

        }

        public Point3D(int[] position)
        {
            this.CurrentPosition = position;
        }

        public int[] CurrentPosition
        {
            set
            {
                CheckIfValid(value, "Invalid coordinates provided");
                this._currentPosition = value;
            }
            get
            {
                return this._currentPosition;
            }
        }

        public static int[] StartingPosition
        {
            get
            {
                return STARTING_POINT;
            }
        }

        public void CheckIfValid(int[] value, String message)
        {
            if (value.Length != 3)
            {
                throw new ArgumentException(message);
            }

            for (int i = 0; i < 3; i++)
            {
                if (value[i] < 0)
                {
                    throw new ArgumentException(message);
                }
            }
        }
    }
}

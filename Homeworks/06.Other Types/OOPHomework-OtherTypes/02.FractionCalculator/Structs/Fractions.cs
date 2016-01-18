using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.FractionCalculator.Structs
{
    public struct Fraction
    {
        public long Numerator { get; set; }
        private long _denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Denominator
        {
            set
            {
                CheckIfZero(value);
                this._denominator = value;
            }
            get
            {
                return this._denominator;
            }
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            BigInteger lcm = LeastCommonMultiple(f1.Denominator, f2.Denominator);
            BigInteger denominator = lcm;
            BigInteger numerator = (f1.Numerator * lcm / f1.Denominator) + (f2.Numerator * lcm / f2.Denominator);
            BigInteger gcd = GreatestCommonDivisor(numerator, denominator);

            numerator /= gcd;
            denominator /= gcd;

            if (numerator < long.MinValue || numerator > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Numerator must be a valid long number");
            }
            if (denominator < long.MinValue || denominator > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Denominator must be a valid long number");
            }

            return new Fraction((long)numerator, (long)denominator);
        }

        public static Fraction operator - (Fraction f1, Fraction f2)
        {
            BigInteger lcm = LeastCommonMultiple(f1.Denominator, f2.Denominator);
            BigInteger denominator = lcm;
            BigInteger numerator = (f1.Numerator * lcm / f1.Denominator) - (f2.Numerator * lcm / f2.Denominator);
            BigInteger gcd = GreatestCommonDivisor(numerator, denominator);

            numerator /= gcd;
            denominator /= gcd;

            if (numerator < long.MinValue || numerator > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Numerator must be a valid long number");
            }
            if (denominator < long.MinValue || denominator > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Denominator must be a valid long number");
            }

            return new Fraction((long)numerator, (long)denominator);
        }

        public override string ToString()
        {
            return String.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }

        private void CheckIfZero(long value)
        {
            if (value == 0)
            {
                throw new ArgumentOutOfRangeException("Denominator can't be 0");
            }
        }

        private static BigInteger LeastCommonMultiple(long x, long y)
        {
            BigInteger result = (x * y) / GreatestCommonDivisor(x, y);
            return result;
        }

        private static BigInteger GreatestCommonDivisor(BigInteger x, BigInteger y)
        {
            while (y != 0)
            {
                BigInteger tmp = y;
                y = x % y;
                x = tmp;
            }

            return x;
        }

        private static long GreatestCommonDivisor(long x, long y)
        {
            while (y != 0)
            {
                long tmp = y;
                y = x % y;
                x = tmp;
            }

            return x;
        }
    }
}

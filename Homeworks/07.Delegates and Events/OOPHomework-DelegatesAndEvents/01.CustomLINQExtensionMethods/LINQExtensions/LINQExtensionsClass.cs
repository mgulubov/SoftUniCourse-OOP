using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomLINQExtensionMethods.LINQExtensions
{
    public static class LINQExtensionsClass
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();

            foreach (T i in collection)
            {
                if (!predicate(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        public static TSelector Max<TSource,TSelector>(this IEnumerable<TSource> source, Func<TSource, TSelector> selector) 
        {
            TSelector result = default(TSelector);
            foreach (IComparable grade in source)
            {
                if (grade.CompareTo(result) == 1)
                {
                    result = (TSelector)grade;
                }
            }

            return result;
        }
    }
}

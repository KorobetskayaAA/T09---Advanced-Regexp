using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    static class NumbersExtensions
    {
        static TResult Median<T, TResult>(this IEnumerable<T> numbers, Func<T, T, TResult> halfSum)
        {
            var numbersSorted = numbers.ToArray();
            Array.Sort(numbersSorted);
            int n = numbersSorted.Length;
            T lowerMiddle = numbersSorted[n / 2 + n % 2];
            T upperMiddle = numbersSorted[n / 2 + 1];
            return halfSum(lowerMiddle, upperMiddle);
        }

        public static double Median(this IEnumerable<double> numbers)
        {
            return Median(numbers, (a, b) => (a + b) / 2);
        }

        public static float Median(this IEnumerable<float> numbers)
        {
            return Median(numbers, (a, b) => (a + b) / 2);
        }

        public static float Median(this IEnumerable<int> numbers)
        {
            return Median(numbers, (a, b) => (a + b) / 2);
        }

        public static double Median(this IEnumerable<long> numbers)
        {
            return Median(numbers, (a, b) => (a + b) / 2);
        }
    }
}

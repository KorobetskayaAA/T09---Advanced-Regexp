using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class ProgramExtensions
    {

        static void Main(string[] args)
        {
            Console.WriteLine("HellO worLd! ".ToFirstUpperCase());
            Console.WriteLine("Hello World!".CharCount('l'));

            var arr = new[] { 9, 89, 78.6, 56, -9, 0, 1 };
            Console.WriteLine(arr.Median());
        }
    }
}

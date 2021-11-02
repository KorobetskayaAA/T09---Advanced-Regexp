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
        }
    }
}

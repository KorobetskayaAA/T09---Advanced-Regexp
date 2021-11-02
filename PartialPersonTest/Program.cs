using Persons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PartialPersonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = File.ReadAllText("TestPersons.csv")
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => Person.FromCsvRow(line))
                .ToArray();
            Array.Sort(persons);
            Console.WriteLine(string.Join("\n\n", persons as IEnumerable<Person>));
        }
    }
}

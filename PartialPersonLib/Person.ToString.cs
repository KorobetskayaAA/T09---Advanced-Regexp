using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    partial class Person
    {
        public override string ToString()
        {
            return Id + "\n" + FullName + "\n" + BirthDate.ToString("dd.MM.yyyy");
        }

        const string csvSeparator = ";";

        public string ToCsvRow()
        {
            return string.Join(csvSeparator, new List<string>() 
                {
                    Id,
                    FirstName, 
                    LastName,
                    BirthDate.ToString(),
                    Username,
                    Email,
                }
            );
        }

        public static Person FromCsvRow(string row)
        {
            var values = row.Split(csvSeparator);
            return new Person()
            {
                Id = values[0],
                FirstName = values[1],
                LastName = values[2],
                BirthDate = DateTime.Parse(values[3]),
                Username = values[4],
                Email = values[5],
            };
        }
    }
}

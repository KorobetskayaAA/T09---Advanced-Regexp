using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public DateTime BirthDate { get; set; }
    }
}

using System;

namespace Persons
{
    public partial class Person : IComparable
    {
        public int CompareTo(object o)
        {
            Person p = o as Person;
            if (p != null)
                return FullName.CompareTo(p.FullName);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}

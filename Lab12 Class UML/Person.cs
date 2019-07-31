using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Class_UML
{
    abstract class Person
    {
        private protected string Name { get; set; }
        private protected string Address { get; set; }

        public Person()
        {

        }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Person[name: {Name}, address: {Address}]";
        }
    }
}

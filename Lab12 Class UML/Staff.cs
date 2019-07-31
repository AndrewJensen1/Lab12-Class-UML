using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Class_UML
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }


        public Staff()
        {

        }
        public Staff(string school, double pay, string name, string address)
            :base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public override string ToString()
        {
            return $"Person[name: {Name}, address: {Address}, school: {School}, pay: {Pay}]";
        }
    }
}

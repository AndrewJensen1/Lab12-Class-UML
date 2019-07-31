using System;
using System.Collections.Generic;

namespace Lab12_Class_UML
{
    class Program
    {
        List<Person> person = new List<Person>
        {
            new Student("C#", 2019, 10000, "AJ", "555 Waterbury Ave"),
            new Student("C#", 2019, 10000, "Bob", "222 Bonk Dr"),
            new Student("C#", 2019, 10000, "Jane", "111 Yooo St"),
            new Staff("Grand Circus", 40000, "Matt", "1570 Woodward"),
            new Staff("Grand Circus", 40000, "John", "1570 Woodward")
        };

        static void Main(string[] args)
        {

        }
    }
}

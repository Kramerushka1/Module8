using System;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Module8
{
    class Program
    {
        
    }
    
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Person(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}

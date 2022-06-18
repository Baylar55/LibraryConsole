using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int ID { get; }
        private static int id;
        public Employee()
        {
            ID = ++id;
        }
    }
}

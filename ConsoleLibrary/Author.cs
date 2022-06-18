using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int ID { get; }
        private static int id;
        public List<Book> authorbooks;


        public Author()
        {
            authorbooks = new List<Book>();
            ID = ++id;
        }
    }
}

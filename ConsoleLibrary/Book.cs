using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class Book
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int ID { get; }
        private static int id;
        public List<Author> authors;
        public Book()
        {
            authors = new List<Author>();
            ID = ++id;
        }
    }
}

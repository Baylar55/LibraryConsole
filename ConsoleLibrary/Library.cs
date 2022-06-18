using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class Library
    {
        public string Name { get; set; }

        public List<Book> books;
        public List<Employee> employees;
        public List<Author> authors;
        public Library()
        {
            authors = new List<Author>();
            books = new List<Book>();
            employees = new List<Employee>();
        }
    }
}

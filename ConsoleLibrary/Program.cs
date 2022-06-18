using System;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lb = new Library();

            while (true)
            {
             Console.WriteLine("1-Add employee  2-Add author  3-Add book  4-Remove employee  5-Remove book");
                string result = Console.ReadLine();
                switch (result)
                {
                    case "1":

                        #region AddEmployee 

                        Employee emp = new Employee();
                    nameofemp:
                        Console.Write("Enter employee name :  ");
                        string name = Console.ReadLine();
                        bool isName = string.IsNullOrWhiteSpace(name);
                        if (isName)
                        {
                            Console.WriteLine("Enter name correctly:");
                            goto nameofemp;
                        }
                        emp.Name = name;
                        Console.Write("Enter employee surname :  ");
                    empsurname:
                        string surname = Console.ReadLine();
                        bool issurName = string.IsNullOrWhiteSpace(surname);
                        if (isName)
                        {
                            Console.WriteLine("Enter surname correctly:");
                            goto empsurname;
                        }
                        emp.Surname = surname;
                        Console.Write("Enter employee age :  ");
                    INPUTAGE:
                        string age = Console.ReadLine();
                        bool isEmpAge = int.TryParse(age, out int employeerage);
                        if (!isEmpAge)
                        {
                            Console.WriteLine("Enter age correctly!!");
                            goto INPUTAGE;
                        }
                        emp.Age = employeerage;
                        lb.employees.Add(emp);
                        Console.WriteLine("Employeer is added");
                        break;

                    #endregion


                    case "2":

                        #region AddAuthor

                        Author author = new Author();
                        Console.Write("Enter author name :  ");
                    nameofauthor:
                        name = Console.ReadLine();
                        bool isAName = string.IsNullOrWhiteSpace(name);
                        if (isAName)
                        {
                            Console.WriteLine("Enter name correctly:");
                            goto nameofauthor;
                        }
                        author.Name = name;
                        Console.Write("Enter employee surname :  ");
                    surnameofemp:
                        surname = Console.ReadLine();
                        bool isAsurname = string.IsNullOrWhiteSpace(surname);
                        if (isAsurname)
                        {
                            Console.WriteLine("Enter name correctly:");
                            goto surnameofemp;
                        }
                        author.Surname = surname;
                        Console.Write("Enter employee age :  ");
                    INPUTAGE2:
                        age = Console.ReadLine();
                        bool isAutAge = int.TryParse(age, out int authorage);
                        if (!isAutAge)
                        {
                            Console.WriteLine("Enter age correctly!!");
                            goto INPUTAGE2;
                        }
                        author.Age = authorage;
                        lb.authors.Add(author);
                        break;

                    #endregion

                    case "3":

                        if (lb.authors.Count == 0)
                        {
                            Console.WriteLine($"Author list is empty!!", ConsoleColor.DarkRed);
                            goto case "2";
                        }

                        Book bk = new Book();
                    nameofbook:
                        Console.WriteLine("Enter name of book:");
                        name = Console.ReadLine();
                        bool isBName = string.IsNullOrWhiteSpace(name);
                        if (isBName)
                        {
                            Console.WriteLine("Enter name correctly:");
                            goto nameofbook;
                        }
                        bk.Name = name;
                        Console.Write("Enter book type:");
                        string booktype = Console.ReadLine();
                        bk.Type = booktype;
                        foreach (var item in lb.authors)
                        {
                            Console.WriteLine(item.ID +" "+item.Name);
                        }
                    AId:
                        Console.WriteLine("Choose author/authors with Id:");
                        string aut = Console.ReadLine();
                        string[] autId = aut.Split(",");
                        foreach (var item in autId)
                        {
                            bool isAutId = int.TryParse(aut, out int AuthorId);
                            if (!isAutId)
                            {
                                Console.WriteLine("Enter id correctly");
                                goto AId;
                            }
                            foreach (var item2 in lb.authors)
                            {
                                if (item2.ID == AuthorId)
                                {
                                    item2.authorbooks.Add(bk);
                                    bk.authors.Add(item2);
                                }
                            }
                        }
                        lb.books.Add(bk);
                        Console.WriteLine($"{bk.Name} is succesfully added.");



                        break;



                    case "4":

                        #region RemoveEmployee
                        foreach (var item in lb.employees)
                        {
                            Console.WriteLine(item.ID +" "+item.Name);
                        }
                        Console.WriteLine("Enter employeer id which you want to remove :  ");
                        string remId = Console.ReadLine();
                        bool isremId = int.TryParse(remId, out int employeerId);
                        if (!isremId)
                        {
                            Console.WriteLine("Enter age correctly!!");
                            goto case "3";
                        }
                        foreach (var item in lb.employees)
                        {
                            if (item.ID == employeerId)
                            {
                                lb.employees.Remove(item);
                                Console.WriteLine($"{item} is removed from employees.");
                            }
                        }
                        break;

                    #endregion

                    case "5":

                        #region RemoveBook
                        foreach (var item in lb.books)
                        {
                            Console.WriteLine(item.ID +" "+item.Name);
                        }
                        Console.WriteLine("Enter book id which you want to remove :  ");
                        string empId = Console.ReadLine();
                        bool isemId = int.TryParse(result, out int bookId);
                        if (!isemId)
                        {
                            Console.WriteLine("Enter id correctly!!");
                            goto case "3";
                        }
                        foreach (var item in lb.books)
                        {
                            if (item.ID == bookId)
                            {
                                lb.books.Remove(item);
                                Console.WriteLine($"{item} is removed from employees.");
                            }
                        }
                        break;

                    #endregion

                    default:
                        break;
                }
            }

        }
    }
}

using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("NAHID", "17-34226-1", "CSE", 3.33f);
            s2.ShowInfo();

            Account a1 = new Account();
            Account a2 = new Account("Nahid Sultana", "17-34226-1", 30000);
            a2.ShowInfo();

            Book b1 = new Book();
            Book b2 = new Book("Manobi", "Humayun Ahmed", "33-33", "Novel", 100);
            b2.ShowInfo();

            Library l1 = new Library();
            Library l2 = new Library("AIUB Library", "Kuratoli", 10000,10);
            l2.ShowInfo();

            Borrow b3 = new Borrow();
            Borrow b4 = new Borrow("Borrowed", "Manobi", "Humayun Ahmed", "33-33", "Novel", 100);
            b4.ShowInfo();
        }
    }
}

using System;
namespace Lab6
{
    public class Library
    {
        private string libName;
        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }
        private string libAddress;
        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        private int totalBook;
        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        private int bookCount;
        public int BookCount
        {
            get { return bookCount; }
            set { bookCount = value; }
        }
        public Library()
        {
            Console.WriteLine("Library Default");
        }
        public Library(string libName, string libAddress,int totaBook, int bookCount)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
            this.bookCount = bookCount;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Library:" + libName);
            Console.WriteLine("Library Address:" + libAddress);
            Console.WriteLine("Total Books:" + totalBook);
        }
    }
}

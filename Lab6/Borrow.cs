using System;
namespace Lab6
{
    public class Borrow
    {
        private string bookInfo;
        public string BookInfo
        {
            get { return bookInfo; }
            set { bookInfo = value; }
        }
        private int bookCount;
        public int BookCount
        {
            get { return bookCount; }
            set { bookCount = value; }
        }
        public Borrow()
        {
            Console.WriteLine("Library Default");
        }
        public Borrow(string bookInfo, string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookInfo = bookInfo;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Borrow Book Info:" + bookInfo);
        }
        
    }
   
}

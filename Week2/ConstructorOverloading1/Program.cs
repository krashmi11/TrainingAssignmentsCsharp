using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading1
{
    class Book
    {
        private string bookName;
        private string authorName;
        private float price;
        public Book(string bookName)
        {
            this.bookName = bookName;
        }

        public Book(string bookName,string authorName)
        {
            this.bookName=bookName;
            this.authorName = authorName;
        }

        public Book(string bookName, string authorName,float price)
        {
            this.bookName = bookName;
            this.authorName = authorName;
            this.price = price;
        }

        public void Display()
        {
            Console.WriteLine("Book Name:" + bookName);
            Console.WriteLine("Author name:"+authorName);
            Console.WriteLine("Price:"+price);
            Console.WriteLine("------------------------------------------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Pro C#");
            book1.Display();

            book1 = new Book("Wings Of Fire An Autobiography", "Arun Tiwari");
            book1.Display();

            book1 = new Book("Wings Of Fire An Autobiography", "Arun Tiwari", 122);
            book1.Display();
            
        }
    }
}

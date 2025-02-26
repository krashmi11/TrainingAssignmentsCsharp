using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance5
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string PublicationDate { get; set; }

        public Book(int id,string title, string authorName, string publicationDate)
        {
            this.Id = id;
            this.Title = title;
            this.AuthorName = authorName;
            this.PublicationDate = publicationDate;
        }

        public void Display()
        {
            Console.WriteLine("Id of book:" + Id);
            Console.WriteLine("Book Name:"+Title);
            Console.WriteLine("Author Name:"+AuthorName);
            Console.WriteLine("Publication Date:" + DateTime.Parse(PublicationDate).ToLongDateString());
            Console.WriteLine();
        }
    }

    class Library
    {
        static private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added!!\n");
        }
        public int RemoveBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.ToLower()==title.ToLower())
                {
                    books.Remove(book);
                    return book.Id;
                }
            }
            return -1;
        }
        public Book findBookByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    return book;
                }
            }
            return null;
        }

        public void getAllBookInfo()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No book found!\n");
            }
            else
            {
                foreach (Book book in books)
                {
                    book.Display();

                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool success = true;
            do
            {
                Console.WriteLine("\"Welcome to Library Management System\"");
                Console.WriteLine("Enter 1 to Add Book:");
                Console.WriteLine("Enter 2 to find Book:");
                Console.WriteLine("Enter 3 to Remove Book:");
                Console.WriteLine("Enter 4 to get Information of all Books:");

                Console.Write("Enter input:");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Write("Enter unique identification number of book:");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title of book:");
                        string name = Console.ReadLine();
                        Console.Write("Enter Author name of the book:");
                        string author = Console.ReadLine();
                        Console.Write("Enter publication Date(dd-MM-YYYY) format:");
                        string date = Console.ReadLine();
                        Book book = new Book(id, name, author, date);
                        library.AddBook(book);

                        break;

                    case 2:
                        Console.WriteLine("Enter title of the book:");
                        name = Console.ReadLine();
                        book = library.findBookByTitle(name);
                        if (book == null)
                        {
                            Console.WriteLine("Book not found!\n");
                        }
                        else
                        {
                            book.Display();
                        }
                        break;

                    case 3:
                        Console.Write("Enter title of book to remove:");
                        name = Console.ReadLine();
                        if (library.RemoveBook(name) == -1)
                        {
                            Console.WriteLine("Book not found!\n");
                        }
                        else
                        {
                            Console.WriteLine("Book removed successfully!\n");
                        }
                        break;
                    case 4:
                        library.getAllBookInfo();
                        break;
                    default:
                        Console.WriteLine("Invalid Input!\n");
                        break;


                }
                Console.WriteLine("Do you want to continue?(y/n)");
                string choice= Console.ReadLine();
                if (choice == "n") break;
                
            } while (success);


           
           
        }
    }
}

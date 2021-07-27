using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashset
{
    class Book
    {
        int bookId;
        string bookName;
        string author;
        int price;

        public Book(int bookId, string bookName, string author, int price)
        {
            this.BookId = bookId;
            this.BookName = bookName;
            this.Author = author;
            this.Price = price;
        }

        public int BookId { get => bookId; set => bookId = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public int Price { get => price; set => price = value; }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   bookId == book.bookId &&
                   bookName == book.bookName &&
                   author == book.author &&
                   price == book.price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(bookId, bookName, author, price);
        }
    }
    class HashSetClassBook
    {
        static void Main(string[] args)
        {
            HashSet<Book> hsbk = new HashSet<Book>();
            Book b1 = new Book(12, "C#", "Andrean", 4500);
            Book b2 = new Book(11, "C++", "Andrean", 4500);
            Book b3 = new Book(12, "C#", "Andrean", 4500);
            Book b4 = new Book(12, "C#", "Andrean", 4500);
            Book b5 = new Book(22, ".net", "Andrean", 4500);
            Book b6 = new Book(42, "java", "Andrean", 4500);

            b1.GetHashCode();
            b2.GetHashCode();
            b3.GetHashCode();
            b4.GetHashCode();
            b5.GetHashCode();
            b6.GetHashCode();
            
            hsbk.Add(b1);
            hsbk.Add(b2);
            hsbk.Add(b3);
            hsbk.Add(b4);
            hsbk.Add(b5);
            hsbk.Add(b6);

            foreach (var data in hsbk)
                Console.WriteLine($"{data.BookId},{data.BookName},{data.Author},{data.Price}");
        }
    }
}

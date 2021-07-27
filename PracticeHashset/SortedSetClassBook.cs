using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashset
{
    class Books:IComparable<Books>
    {
        int bookIds;
        string bookNames;
        string authors;
        int prices;

        public Books(int bookIds, string bookNames, string authors, int prices)
        {
            this.BookIds = bookIds;
            this.BookNames = bookNames;
            this.Authors = authors;
            this.Prices = prices;
        }

        public int BookIds { get => bookIds; set => bookIds = value; }
        public string BookNames { get => bookNames; set => bookNames = value; }
        public string Authors { get => authors; set => authors = value; }
        public int Prices { get => prices; set => prices = value; }

        public int CompareTo(Books other)
        {
            return this.bookIds.CompareTo(other.bookIds);
        }
    }
    class SortedSetClassBook
    {
        static void Main(string[] args)
        {
            SortedSet<Books> ssbk = new SortedSet<Books>();
           ssbk.Add(new Books(12, "C#", "Andrean", 4500));
            ssbk.Add(new Books(11, "C++", "Andrean", 4500));
            ssbk.Add(new Books(12, "C#", "Andrean", 4500));
            ssbk.Add(new Books(12, "C#", "Andrean", 4500));
            ssbk.Add(new Books(22, ".net", "Andrean", 4500));
            ssbk.Add(new Books(42, "java", "Andrean", 4500));

            foreach (var data in ssbk)
                Console.WriteLine($"{data.BookIds},{data.BookNames},{data.Authors},{data.Prices}");
        }
    }
}

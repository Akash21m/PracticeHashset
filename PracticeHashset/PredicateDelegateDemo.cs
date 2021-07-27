using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashset
{
    class PredicateDelegateDemo
    {
        static void Main(string[] args)
        {
            Predicate<int> even = (a) => a % 2 == 0;
            Console.WriteLine(even(45));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashset
{
    class FuncDelegateDemo
    {
        static void Main(string[] args)
        {
            Func<int, double> aa = (r) => 3.14 * r * r;
            Console.WriteLine(aa(3));
        }
    }
}

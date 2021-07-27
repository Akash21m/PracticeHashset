using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashset
{
    class ActionDelegateDemo
    {
        public static void area(double height, double width)
        {
            Console.WriteLine("Area is: " + (width * height));
        }

        public static void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: " + 2 * (width + height));
        }
        static void Main(string[] args)
        {
            Action<double, double> dlgt = area;
            dlgt(10, 90);
            dlgt = perimeter;
            dlgt(10, 90);
        }
    }
}

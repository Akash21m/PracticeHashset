using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashset
{
    public delegate void rectDelegateMulti(double height, double width);
    class MulticastDelegateDemo
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
            rectDelegateMulti ptr = area;
            ptr = ptr + perimeter;
            ptr(45, 5);
        }
    }
}

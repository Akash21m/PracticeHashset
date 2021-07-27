using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashset
{
    public delegate void rectDelegate(double height,double width);

    class SingleDelegateDemo
    {
        public static void area(double height, double width)
        {
            Console.WriteLine("Area is: "+(width * height));
        }

        public static void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: "+2 * (width + height));
        }
        static void Main(string[] args)
        {
            rectDelegate rd1 = new rectDelegate(area);
            rd1(12, 2);
            rectDelegate rd2 = perimeter;
            rd2(45, 5);
        }
    }
}

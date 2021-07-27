using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeHashset
{
    class SortedSetDemo
    {
        static void Main(string[] args)
        {
            SortedSet<int> my_Set1 = new SortedSet<int>();
            my_Set1.Add(101);
            my_Set1.Add(1001);
            my_Set1.Add(10001);
            my_Set1.Add(100001);
            Console.WriteLine("Elements of my_Set1:");
            foreach (var val in my_Set1)
            {
                Console.WriteLine(val);
            }

            SortedSet<int> my_Set2 = new SortedSet<int>() {
                                202,2002,20002,200002};
            Console.WriteLine("Elements of my_Set2:");
            foreach (var valu in my_Set2)
            {
                Console.WriteLine(valu);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeHashset
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>();
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

          
            HashSet<int> myhash2 = new HashSet<int>() {10,
                               100,1000,10000,100000};

            Console.WriteLine("Elements of myhash2:");
            foreach (var valu in myhash2)
            {
                Console.WriteLine(valu);
            }

            HashSet<int> myhash3 = new HashSet<int>() {1000,
                               100,1000,10000,100000,10,100};

            Console.WriteLine("Elements of myhash3:");
            foreach (var value in myhash3)
            {
                Console.WriteLine(value);
            }
        }
    }
}

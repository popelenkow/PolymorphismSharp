using Sample.MethodDo12;
using Sample.MethodDo21;
using Sample.Models;
using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int arg = 7;
            var arr1 = new A1[]
            {
                //new A1(),
                new B1()
            };
            var arr2 = new A2[]
            {
                //new A2(),
                new B2()
            };

            Console.WriteLine("Do12");
            foreach (var it1 in arr1)
            {
                foreach (var it2 in arr2)
                {
                    Console.WriteLine(it1.GetType().Name + " " + it2.GetType().Name + ":");
                    it1.Do12(it2, arg);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Do21");
            foreach (var it1 in arr1)
            {
                foreach (var it2 in arr2)
                {
                    Console.WriteLine(it1.GetType().Name + " " + it2.GetType().Name + ":");
                    it1.Do21(it2, arg);
                    Console.WriteLine();
                }
            }
        }
    }
}

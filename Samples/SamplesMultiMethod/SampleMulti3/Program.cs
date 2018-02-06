using Sample.Models;
using System;
using Sample.MethodCalculate;
using System.Collections.Generic;

namespace SampleMulti3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arg1 = 1;
            float arg2 = 2f;
            string arg3 = "123";
            var arr = new List<A>
            {
                new A(),
                new B(),
                new C()
            };
            foreach (var it in arr)
            {
                Console.WriteLine(it.GetType().Name + ":");
                double res = it.Calculate(arg1, arg2, arg3);
                Console.WriteLine("Returned " + res);
                Console.WriteLine();
            }
        }
    }
}

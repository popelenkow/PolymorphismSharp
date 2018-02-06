using System;
using Sample.MethodDo;
using Sample.Models;
using System.Collections.Generic;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IA> arr = new List<IA>();
            arr.Add(new A1());
            arr.Add(new A2());
            arr.Add(new BBase());
            arr.Add(new B1());
            arr.Add(new B2());
            arr.Add(new B3());

            double arg;

            arg = 7;
            Console.WriteLine("Current arg: " + arg.ToString());
            foreach (IA it in arr)
            {
                string result =  it.Do(arg);
                Console.WriteLine(it.GetType().Name + " call do and returned: " + result);
            }

            Console.WriteLine("");
            arg = -9.3;
            Console.WriteLine("Current arg: " + arg.ToString());
            foreach (IA it in arr)
            {
                string result = it.Do(arg);
                Console.WriteLine(it.GetType().Name + " call do and returned: " + result);
            }
        }
    }
}

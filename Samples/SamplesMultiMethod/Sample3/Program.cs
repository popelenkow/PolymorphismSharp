using System;
using Sample.MethodSet;
using Sample.MethodRead;
using Sample.Models;
using System.Collections.Generic;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IA> arr = new List<IA>();
            arr.Add(new A());
            arr.Add(new B());
            arr.Add(new C());


            int arg = 7;

            foreach (IA it in arr)
            {
                it.Set(arg);
            }

            Console.WriteLine("");

            foreach (IA it in arr)
            {
                var result = it.Read();
                Console.WriteLine("class " + it.GetType().Name + ": " + result);
            }
        }
    }
}

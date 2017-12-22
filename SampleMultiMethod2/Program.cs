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
            arr.Add(new A());
            arr.Add(new BC());
            arr.Add(new CB());
            arr.Add(new DE());
            arr.Add(new ED());


            int argInt = 7;
            double argDouble = 5.4;
            Console.WriteLine("argInt: " + argInt.ToString());
            Console.WriteLine("argDouble: " + argDouble.ToString());
            Console.WriteLine("");

            foreach (IA it in arr)
            {
                string result = it.Do(argInt, argDouble);
                Console.WriteLine(it.GetType().Name + " returned: " + result);
                Console.WriteLine("");
            }
        }
    }
}

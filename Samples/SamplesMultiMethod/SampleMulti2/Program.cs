using Sample.Models;
using System;
using Sample.MethodDo;
using System.Collections.Generic;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new A[]
            {
                new BC(),
                new CB()
            };
            foreach (var it in arr)
            {
                Console.WriteLine(it.GetType().Name + ":");
                it.Do(args);
                Console.WriteLine();
            }
        }
    }
}

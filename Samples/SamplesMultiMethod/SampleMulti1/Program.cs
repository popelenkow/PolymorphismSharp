using Sample.Models;
using System;
using Sample.MethodDo;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using PolymorphismSharp.Methods;

namespace Sample
{
   

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<A>
            {
                new B(),
                new C(),
                new D()
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
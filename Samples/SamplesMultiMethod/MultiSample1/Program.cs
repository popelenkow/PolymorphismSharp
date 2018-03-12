using Sample.Parameters;
using System;
using Sample.MethodDo;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using PolymorphismSharp.Methods;
using System.Runtime.CompilerServices;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new A[]
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
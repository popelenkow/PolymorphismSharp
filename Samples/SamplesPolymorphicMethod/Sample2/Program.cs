using System;
using System.Collections.Generic;
using Sample.Args;
using Sample.MethodDo;
using Sample.Models;
using Sample.Results;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new List<IA>();
            arr.Add(new A());
            arr.Add(new B());
            arr.Add(new C());
            foreach (var it in arr)
            {
                Console.WriteLine(it.GetType().Name + " call do:");
                IArg arg = new Arg
                {
                    String = "arg"
                };
                IResult result = it.Do(arg);
                Console.WriteLine(it.GetType().Name + " returned result:");
                foreach (var r in result.Strings)
                {
                    Console.WriteLine(r);
                }
            }
        }
    }
}

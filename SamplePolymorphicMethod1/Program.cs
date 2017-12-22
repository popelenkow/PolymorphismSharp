using System;
using System.Collections.Generic;
using Sample.Models;
using Sample.MethodDo;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<IA>();
            arr.Add(new CB());
            arr.Add(new BC());
            foreach (var it in arr)
            {
                Console.WriteLine(it.GetType().Name + " call do:");
                it.Do();
            }
        }
    }
}

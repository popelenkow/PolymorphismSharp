using System;
using Sample.MethodDo12;
using Sample.MethodDo21;
using Sample.Models;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IA1 a1 = new A1();
            IA2 a2 = new A2();
            int arg = 4;
            a1.Do21(a2, arg);
            Console.WriteLine("");
            a1.Do12(a2, arg);
        }
    }
}

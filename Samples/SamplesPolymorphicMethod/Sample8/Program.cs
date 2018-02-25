using System;
using Sample.MethodDo12;
using Sample.MethodDo21;
using Sample.Models;
using System.Linq;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = typeof(IMethodDo21<,>);
            var t = typeof(IMethodDo12<IA1, IA2>);
            var g = t.Assembly.GetType(t.Namespace + "." + t.Name);
            var h = g.GetGenericArguments();
            var k = g.GetMethods()[0].GetParameters();
            var gg = h.Select(x =>
            {
                for (int i = 0; i < k.Length; i++)
                {
                    if (x == k[i].ParameterType)
                    {
                        return i;
                    }
                }
                return -1;
            }).ToArray();
            
            IA1 a1 = new A1();
            IA2 a2 = new A2();
            int arg = 4;
            a1.Do21(a2, arg);
            Console.WriteLine("");
            a1.Do12(a2, arg);
        }
    }
}

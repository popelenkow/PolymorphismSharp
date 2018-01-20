using System;
using System.Collections.Generic;
using Sample.Models;
using Sample.MethodDo;

namespace Sample
{
    interface IK
    {
        void Call(params object[] args);
    }
    class K : IK
    {
        public void Call(params object[] args)
        {
            var t = GetType();
            var f = GetType().GetMethods();
            this.GetType().GetMethod("Call").Invoke(this, args);
        }
    }
    interface IL : IK
    {
        void Call(int i, double d);
    }
    class L : K, IL
    {
        public void Call(int i, double d)
        {
            int f = i;
        }
    }


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
            
            //IK l = new L();
            //l.Call(5, 4.3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo21
{
    public abstract class MethodDo21<TParameter2, TParameter1> : MultiMethod
        where TParameter1 : A1
        where TParameter2 : A2
    {
        public abstract void Call(TParameter2 parameter2, int arg, TParameter1 parameter1);
    }
}

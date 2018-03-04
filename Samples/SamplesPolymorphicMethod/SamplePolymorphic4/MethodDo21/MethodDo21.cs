using PolymorphismSharp.Methods;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.MethodDo21
{
    public abstract class MethodDo21<TParameter2, TParameter1> : PolymorphicMethod<MethodDo21<A2, A1>>
        where TParameter1 : A1
        where TParameter2 : A2
    {
        public abstract void Call(TParameter2 parameter2, int arg, TParameter1 parameter1);
    }
}

using PolymorphismSharp.Methods;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.MethodDo12
{
    public abstract class MethodDo12<TParameter1, TParameter2> : PolymorphicMethod<MethodDo12<A1, A2>>
        where TParameter1 : A1
        where TParameter2 : A2
    {
        public abstract void Call(TParameter2 parameter2, int arg, TParameter1 parameter1);
    }
}

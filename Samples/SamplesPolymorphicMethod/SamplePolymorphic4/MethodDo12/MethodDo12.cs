using PolymorphismSharp.Methods;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.MethodDo12
{
    public abstract class MethodDo12<TModel1, TModel2> : PolymorphicMethod<MethodDo12<A1, A2>>
        where TModel1 : A1
        where TModel2 : A2
    {
        public abstract void Call(TModel2 model2, int arg, TModel1 model1);
    }
}

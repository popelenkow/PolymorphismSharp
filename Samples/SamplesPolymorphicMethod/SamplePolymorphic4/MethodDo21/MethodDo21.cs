using PolymorphismSharp.Methods;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.MethodDo21
{
    public abstract class MethodDo21<TModel2, TModel1> : PolymorphicMethod<MethodDo21<A2, A1>>
        where TModel1 : A1
        where TModel2 : A2
    {
        public abstract void Call(TModel2 model2, int arg, TModel1 model1);
    }
}

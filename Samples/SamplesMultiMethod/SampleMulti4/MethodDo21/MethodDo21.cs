using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo21
{
    public abstract class MethodDo21<TModel2, TModel1> : MultiMethod
        where TModel1 : A1
        where TModel2 : A2
    {
        public abstract void Call(TModel2 model2, int arg, TModel1 model1);
    }
}

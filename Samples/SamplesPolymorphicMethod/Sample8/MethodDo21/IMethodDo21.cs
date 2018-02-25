using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo21
{
    public interface IMethodDo21<TModel2, TModel1> : IPolymorphicMethod
        where TModel1 : IA1
        where TModel2 : IA2
    {
        void Call(TModel2 model2, int arg, TModel1 model1);
    }
}

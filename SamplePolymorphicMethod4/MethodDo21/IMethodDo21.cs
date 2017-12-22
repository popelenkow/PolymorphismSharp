using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo21
{
    interface IMethodDo21<TModel2, TModel1> : IPolymorphicMethod
        where TModel1 : IA1
        where TModel2 : IA2
    {
        void Before(TModel2 model2, int arg, TModel1 model1);
        void After(TModel2 model2, int arg, TModel1 model1);
    }
}

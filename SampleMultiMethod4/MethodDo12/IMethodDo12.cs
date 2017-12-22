using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo12
{
    interface IMethodDo12<TModel1, TModel2> : IMultiMethod
        where TModel1 : IA1
        where TModel2 : IA2
    {
        void Call(TModel2 model2, int arg, TModel1 model1);
    }
}

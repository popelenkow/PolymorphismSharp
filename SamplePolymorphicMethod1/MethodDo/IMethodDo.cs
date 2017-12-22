using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo
{
    interface IMethodDo<TModel> : IPolymorphicMethod
        where TModel : IA
    {
        void Before(TModel model, params object[] args);
        void After(TModel model, params object[] args);
    }
}

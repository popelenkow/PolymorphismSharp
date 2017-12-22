using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodSet
{
    interface IMethodSet<TModel> : IMultiMethod
        where TModel : IA
    {
        void Call(TModel model, int arg);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodSet
{
    interface IMethodSet<TModel> : IPolymorphicMethod
        where TModel : IA
    {
        void Call(TModel model, int arg);
    }
}

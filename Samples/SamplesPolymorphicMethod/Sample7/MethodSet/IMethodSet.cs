using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodSet
{
    public interface IMethodSet<TModel> : IPolymorphicMethod
        where TModel : IA
    {
        void Call(TModel model, int arg);
    }
}

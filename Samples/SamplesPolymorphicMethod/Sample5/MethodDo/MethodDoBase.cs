using Sample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Callables;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    abstract class MethodDoBase<TModel> : PolymorphicMethod, IMethodDo<TModel>
        where TModel : IA
    {
        public abstract void Call(TModel model, params object[] args);
    }
}

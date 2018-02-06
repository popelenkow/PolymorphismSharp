﻿using Sample.Models;
using PolymorphismSharp.Static.Methods;

namespace Sample.MethodDo
{
    public abstract class MethodDoBase<TModel> : MultiMethod, IMethodDo<TModel>
        where TModel : A
    {
        public abstract void Call(TModel model, params object[] args);
    }
}

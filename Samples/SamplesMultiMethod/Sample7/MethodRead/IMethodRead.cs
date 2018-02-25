using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodRead
{
    public interface IMethodRead<TModel> : IMultiMethod
        where TModel : IA
    {
        string Call(TModel model);
    }
}

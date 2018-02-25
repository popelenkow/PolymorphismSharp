using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodRead
{
    public interface IMethodRead<TModel> : IPolymorphicMethod
        where TModel : IA
    {
        string Call(TModel model);
    }
}

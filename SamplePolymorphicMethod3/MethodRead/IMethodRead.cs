using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodRead
{
    interface IMethodRead<TModel> : IPolymorphicMethod<string>
        where TModel : IA
    {
        void Before(TModel model);
        void After(TModel model);
    }
}

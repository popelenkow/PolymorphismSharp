using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;

namespace PolymorphismSharp.Callables
{
    public interface ICallable
    {
        object Call(params object[] args);
    }
}

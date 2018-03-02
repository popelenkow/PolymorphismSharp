using PolymorphismSharp.Callables;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace PolymorphismSharp.Methods.Builder
{
    public static class MultiMethodBuilder
    {
        public static TMethod GetMethod<TMethod>()
            where TMethod : class, IMultiMethod
        {
            var t = ILMethodGenerator.Generate<TMethod>();
            var a = Activator.CreateInstance(t.Dispatcher) as TMethod;
            return a;
        }
    }
}

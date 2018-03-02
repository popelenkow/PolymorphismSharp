using PolymorphismSharp.Reflection;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Methods.Builder
{

    public static class PolymorphicMethodBuilder
    {
        public static TMethod GetMethod<TMethod>()
           where TMethod : class, IPolymorphicMethod
        {
            var t = ILMethodGenerator.Generate<TMethod>();
            var a = Activator.CreateInstance(t.Dispatcher) as TMethod;
            return a;
        }
    }
}

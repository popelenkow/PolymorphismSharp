using PolymorphismSharp.Management;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace PolymorphismSharp.Methods
{
    public static class MultiMethodBuilder
    {
        public static TMethod GetMethod<TMethod>()
            where TMethod : MultiMethod
        {
            var proxy = ILMethodGenerator.Generate(typeof(TMethod));
            var dispatcher = new GeneralizedMethodDispatcher(typeof(TMethod), proxy);
            var a = Activator.CreateInstance(proxy, new object[] { dispatcher }) as TMethod;
            return a;
        }
    }
}

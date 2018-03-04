using PolymorphismSharp.Management;
using PolymorphismSharp.Parametric;
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
        public static TContract GetContract<TContract>()
            where TContract : MultiMethod
        {
            var proxy = ILMethodGenerator.Generate(typeof(TContract));
            var dispatcher = new GeneralizedMethodDispatcher(typeof(TContract), proxy);
            var a = Activator.CreateInstance(proxy, new object[] { dispatcher }) as TContract;
            return a;
        }
    }
}

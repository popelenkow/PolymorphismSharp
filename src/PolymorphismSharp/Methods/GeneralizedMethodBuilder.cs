using PolymorphismSharp.Management;
using PolymorphismSharp.Reflection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PolymorphismSharp.Methods
{

    public static class GeneralizedMethodBuilder
    {
        public static TContract GetContract<TContract>()
            where TContract : class
        {
            var proxy = ILMethodGenerator.Generate(typeof(TContract));
            var dispatcher = new GeneralizedMethodDispatcher(typeof(TContract), proxy);
            var a = Activator.CreateInstance(proxy, new object[] { dispatcher }) as TContract;
            return a;
        }
    }
}

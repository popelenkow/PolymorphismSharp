using PolymorphismSharp.Management;
using PolymorphismSharp.Reflection;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Methods
{

    public static class PolymorphicMethodBuilder
    {
        public static TContract GetContract<TContract>()
           where TContract : PolymorphicMethod<TContract>
        {
            var proxy = ILMethodGenerator.Generate(typeof(TContract));
            var dispatcher = new GeneralizedMethodDispatcher(typeof(TContract), proxy);
            var a = Activator.CreateInstance(proxy, new object[] { dispatcher }) as TContract;
            return a;
        }
    }
}

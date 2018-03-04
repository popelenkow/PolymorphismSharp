using PolymorphismSharp.Management;
using PolymorphismSharp.Reflection;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Methods
{

    public static class PolymorphicMethodBuilder
    {
        public static TMethod GetMethod<TMethod>()
           where TMethod : PolymorphicMethod<TMethod>
        {
            var proxy = ILMethodGenerator.Generate(typeof(TMethod));
            var dispatcher = new GeneralizedMethodDispatcher(typeof(TMethod), proxy);
            var a = Activator.CreateInstance(proxy, new object[] { dispatcher }) as TMethod;
            return a;
        }
    }
}

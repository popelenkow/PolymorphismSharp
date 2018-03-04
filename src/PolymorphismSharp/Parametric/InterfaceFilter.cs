using PolymorphismSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Parametric
{
    static class InterfaceFilter
    {
        public static Predicate<Type> Get(Type contractType, IEnumerable<Type> parameterArgs)
        {
            return ((interfaceType) =>
            {
                var cPar = contractType.GetGenericArguments();
                var iPar = interfaceType.GetGenericArguments();
                var aPar = parameterArgs;
                return cPar.IsAssignableFrom(iPar) && iPar.IsAssignableFrom(aPar);
            });
        }
    }
}

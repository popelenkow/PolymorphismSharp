using PolymorphismSharp.Extensions;
using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Parametric
{
    static class ParametricRealizationFilter
    {
        public static Predicate<RealizationMethodInfo> Get(Type contractType, IEnumerable<Type> parameterArgs)
        {
            return ((realization) =>
            {
                var cPar = contractType.GetGenericArguments();
                var iPar = realization.Interface.GetGenericArguments();
                var aPar = parameterArgs;
                
                return cPar.IsAssignableFrom(iPar) && iPar.IsAssignableFrom(aPar);
            });
        }
    }
}

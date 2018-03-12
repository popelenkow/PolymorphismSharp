using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Extensions;

namespace PolymorphismSharp.Subtype
{
    class SubtypeRealizationFilter
    {
        public static Predicate<RealizationMethodInfo> Get(object[] args)
        {
            return ((realization) =>
            {
                var i = Activator.CreateInstance(realization.Implementation);


                return (bool)realization.Implementation.GetMethod("Pre").Invoke(i, args);
            });
        }
    }
}

using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Subtype
{
    interface ISubtypeDispatcher
    {
        IComparer<RealizationMethodInfo> GetRealizationComparer(object[] args);
        Predicate<RealizationMethodInfo> GetRealizationFilter(object[] args);
    }
}

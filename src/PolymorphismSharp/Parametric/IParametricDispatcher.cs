using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PolymorphismSharp.Methods;


namespace PolymorphismSharp.Parametric
{
    interface IParametricDispatcher
    {
        IComparer<RealizationMethodInfo> GetRealizationComparer(object[] args);
        Predicate<RealizationMethodInfo> GetRealizationFilter(object[] args);
    }

}

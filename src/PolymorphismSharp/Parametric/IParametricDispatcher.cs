using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PolymorphismSharp.Methods;


namespace PolymorphismSharp.Parametric
{
    interface IParametricDispatcher
    {
        IComparer<Type> GetRealizationComparer(object[] args);
        Predicate<Type> GetRealizationFilter(object[] args);
    }

}

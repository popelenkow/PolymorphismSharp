using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Methods
{
    struct RealizationMethodInfo
    {
        public Type Interface { get; set; }
        public Type Implementation { get; set; }
        public static implicit operator RealizationMethodInfo((Type Interface, Type Implementation) realization)
        {
            return new RealizationMethodInfo
            {
                Implementation = realization.Implementation,
                Interface = realization.Interface
            };
        }
    }
}

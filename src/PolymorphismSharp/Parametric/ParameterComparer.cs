using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PolymorphismSharp.Extensions;

namespace PolymorphismSharp.Parametric
{
    class ParameterComparer : IComparer<Type>
    {
        private List<Type> priority;
        public ParameterComparer(Type parameterArg)
        {
            priority = parameterArg.GetClassesAndInterfaces().ToList();
        }
        public int Compare(Type x, Type y)
        {
            if (x == y) return 0;
            foreach (var it in priority)
            {
                if (it == x) return 1;
                if (it == y) return -1;
            }
            return 0;
        }
    }
}

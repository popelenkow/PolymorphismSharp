using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Subtype
{
    class SubtypeRealizationComparer : IComparer<RealizationMethodInfo>
    {
        private List<PriorityComparer> _priorities;
        public SubtypeRealizationComparer(List<PriorityComparer> priorities)
        {
            _priorities = priorities;
        }
        public int Compare(RealizationMethodInfo x, RealizationMethodInfo y)
        {
            foreach (var it in _priorities)
            {
                int c = it.Compare(x.Implementation, y.Implementation);
                if (c != 0) return c;
            }
            return 0;
        }
    }
}

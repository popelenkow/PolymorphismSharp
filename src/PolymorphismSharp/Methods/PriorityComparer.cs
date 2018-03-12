using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Methods
{
    class PriorityComparer : IComparer<Type>
    {
        private List<Type> _priority;
        public PriorityComparer(List<Type> priority)
        {
            _priority = priority;
        }
        public int Compare(Type x, Type y)
        {
            if (x == y) return 0;
            foreach (var it in _priority)
            {
                if (it == y) return 1;
                if (it == x) return -1;
            }
            return 0;
        }
    }
}

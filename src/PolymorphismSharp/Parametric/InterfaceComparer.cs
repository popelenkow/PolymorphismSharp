using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PolymorphismSharp.Extensions;

namespace PolymorphismSharp.Parametric
{
    class InterfaceComparer : IComparer<Type>
    {
        private IEnumerable<IComparer<Type>> _comparers;
        public InterfaceComparer(IEnumerable<Type> parameterArgs)
        {
            _comparers = parameterArgs.Select(x => new ParameterComparer(x)).ToList();
        }
        public int Compare(Type x, Type y)
        {
            var xArgs = x.GetGenericArguments();
            var yArgs = y.GetGenericArguments();

            if (_comparers.Count() != xArgs.Length || xArgs.Length != yArgs.Length) return 0;

            foreach (var it in _comparers.Zip(xArgs, yArgs))
            {
                int ret = it.Value1.Compare(it.Value2, it.Value3);
                if (ret != 0) return ret;
            }
            return 0;
        }
    }
}

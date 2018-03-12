using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PolymorphismSharp.Extensions;
using PolymorphismSharp.Methods;

namespace PolymorphismSharp.Parametric
{
    class ParametricRealizationComparer : IComparer<RealizationMethodInfo>
    {
        private IEnumerable<IComparer<Type>> _comparers;
        public ParametricRealizationComparer(IEnumerable<Type> parameterArgs)
        {
            _comparers = parameterArgs.Select(x => new PriorityComparer(x.GetClassesAndInterfaces().ToList())).ToList();
        }
        public int Compare(RealizationMethodInfo x, RealizationMethodInfo y)
        {
            var xArgs = x.Interface.GetGenericArguments();
            var yArgs = y.Interface.GetGenericArguments();

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

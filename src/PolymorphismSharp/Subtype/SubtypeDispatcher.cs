using PolymorphismSharp.Extensions;
using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismSharp.Subtype
{
    class SubtypeDispatcher : ISubtypeDispatcher
    {
        List<PriorityComparer> _priorities;
        public SubtypeDispatcher()
        {
            _priorities = AppDomain.CurrentDomain.GetDerived().Select(x => new PriorityComparer(x.GetGenericArguments()[0].GetGenericArguments().ToList())).ToList();
        }
        public IComparer<RealizationMethodInfo> GetRealizationComparer(object[] args)
        {
            return new SubtypeRealizationComparer(_priorities);
        }

        public Predicate<RealizationMethodInfo> GetRealizationFilter(object[] args)
        {
            return SubtypeRealizationFilter.Get(args);
        }
    }
}

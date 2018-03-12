
using PolymorphismSharp.Extensions;
using PolymorphismSharp.Methods;
using PolymorphismSharp.Parametric;
using PolymorphismSharp.Subtype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace PolymorphismSharp.Management
{
    class GeneralizedMethodDispatcher : IGeneralizedMethodDispatcher
    {
        private IParametricDispatcher _parametricDispatcher;
        private ISubtypeDispatcher _subtypeDispatcher;
        private Type _contractType;
        private Type _proxyType;
        private List<RealizationMethodInfo> _realizations;

        public GeneralizedMethodDispatcher(Type contractType, Type proxyType)
        {
            _contractType = contractType;
            _proxyType = proxyType;
            _parametricDispatcher = new ParametricDispatcher(contractType);
            _subtypeDispatcher = new SubtypeDispatcher();
            _realizations = AppDomain.CurrentDomain.GetGeneralizedMethods(contractType);
        }


        public object Call(params object[] args)
        {
            return GetMethod(args).Call();
        }


        #region Private
        private IEnumerable<RealizationMethodInfo> GetMethods(object[] args)
        {
            var parametricFilter = _parametricDispatcher.GetRealizationFilter(args);
            var parametricComparer = _parametricDispatcher.GetRealizationComparer(args);
            var subtypeFilter = _subtypeDispatcher.GetRealizationFilter(args);
            var subtypeComparer = _subtypeDispatcher.GetRealizationComparer(args);

            IEnumerable<RealizationMethodInfo> ms = _realizations;

            ms = ms.Where(x => parametricFilter(x));
            ms = ms.Where(x => subtypeFilter(x));
            ms = ms.OrderBy((x => x), parametricComparer);
            ms = ms.OrderBy((x => x), subtypeComparer);
            return ms.ToList();
        }

        private IGeneralizedMethodManager GetMethod(object[] args)
        {
            var ms = GetMethods(args).ToList();
            var manager = new GeneralizedMethodManager(_contractType, args, ms);

            return manager;
        }
        #endregion

    }
}

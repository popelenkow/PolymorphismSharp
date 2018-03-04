
using PolymorphismSharp.Extensions;
using PolymorphismSharp.Methods;
using PolymorphismSharp.Parametric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismSharp.Management
{
    class GeneralizedMethodDispatcher : IGeneralizedMethodManagement
    {
        private IParametricDispatcher _parametricDispatcher;
        private Type _contractType;
        private Type _proxyType;
        private List<(Type Interface, Type Implementation)> _realizations;

        public GeneralizedMethodDispatcher(Type contractType, Type proxyType)
        {
            _contractType = contractType;
            _proxyType = proxyType;
            _parametricDispatcher = new ParametricDispatcher(contractType);
            _realizations = AppDomain.CurrentDomain.GetGeneralizedMethods(contractType);
        }


        public object Call(params object[] args)
        {
            return GetMethod(args).Call(args);
        }


        #region Private
        private IEnumerable<(Type Interface, Type Implementation)> GetMethods(object[] args)
        {
            var parametricFilter = _parametricDispatcher.GetRealizationFilter(args);
            var parametricComparer = _parametricDispatcher.GetRealizationComparer(args);

            IEnumerable<(Type Interface, Type Implementation)> ms = _realizations;

            ms = ms.Where(x => parametricFilter(x.Interface));
            ms = ms.OrderBy((x => x.Interface), parametricComparer);
            return ms.ToList();
        }

        private IGeneralizedMethodManagement GetMethod(object[] args)
        {
            var ms = GetMethods(args).ToList();
            var manager = new GeneralizedMethodManager(_contractType, ms);
            var proxy = Activator.CreateInstance(_proxyType, new object[] { manager });
            manager.Proxy = proxy;
            return manager;
        }
        #endregion

    }
}

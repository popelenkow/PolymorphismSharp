using PolymorphismSharp.Parametric.Extensions;
using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PolymorphismSharp.Callables;

namespace PolymorphismSharp.Parametric.Dispatchers
{
    class DispatcherGeneralizedMethod<TMethod> : IDispatcherGeneralizedMethod<TMethod>
       where TMethod : class, IGeneralizedMethod
    {
        private List<(Type Interface, Type Implementation)> Methods { get; set; }

        #region Init
        public DispatcherGeneralizedMethod()
        {
            Methods = GetGeneralizedMethods();
        }
        private List<(Type Interface, Type Implementation)> GetGeneralizedMethods()
        {
            var methods = new List<(Type Interface, Type Implementation)>();
            var types = AppDomain.CurrentDomain
                                 .GetGeneralizedMethods(typeof(TMethod));

            foreach (var implementationMethod in types)
            {
                IEnumerable<Type> interfacesMethod = implementationMethod.GetInheritedMethods(typeof(TMethod));
                foreach (var interfaceMethod in interfacesMethod)
                {
                    methods.Add((interfaceMethod, implementationMethod));
                }
            }
            return methods;
        }
        #endregion

        protected IEnumerable<(Type Interface, Type Implementation)> GetMethods(params object[] argGenerics)
        {
            var typeGenerics = new List<Type>();
            foreach (var i in argGenerics)
            {
                typeGenerics.Add(i.GetType());
            }
            IEnumerable<(Type Interface, Type Implementation)> ms = Methods;
            ms = ms.FilterImplementedMethods(typeGenerics, x => x.Interface);
            ms = ms.SortGeneralizedMethods(typeof(TMethod).GetGenericsPriority(typeGenerics), x => x.Interface);
            var r = new List<(Type Interface, Type Implementation)>();
            foreach (var m in ms)
            {
                r.Add(m);
            }
            return r;
        }

        public ICallable GetMethod(params object[] argGenerics)
        {
            if (typeof(TMethod).GetInterface("IMultiMethod") != null)
            {
                var ms = GetMethods(argGenerics);
                //var m = (ms.Count() == 0) ? null : ms.First();
                var m = ms.First();
                return new MultiCall(m);
            }
            if (typeof(TMethod).GetInterface("IPolymorphicMethod") != null)
            {
                return new PolymorphicCall
                {
                    Pairs = GetMethods(argGenerics).ToList()

                };
            }
            return null;
        }


    }

}

using PolymorphismSharp.Parametric.Extensions;
using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PolymorphismSharp.Callables;

namespace PolymorphismSharp.Parametric.Dispatchers
{
    class ParametricDispatcher : IParametricDispatcher
    {
        private Type _methodType { get; set; }
        private List<(Type Interface, Type Implementation)> _methods { get; set; }
        private int[] _indexGenerics;

        #region Init
        public ParametricDispatcher(Type methodType)
        {
            _methodType = methodType;
            _methods = GetGeneralizedMethods();
            _indexGenerics = GetIndexGenerics();
        }
        private List<(Type Interface, Type Implementation)> GetGeneralizedMethods()
        {
            var methods = new List<(Type Interface, Type Implementation)>();
            var types = AppDomain.CurrentDomain
                                 .GetGeneralizedMethods(_methodType);

            foreach (var implementationMethod in types)
            {
                IEnumerable<Type> interfacesMethod = implementationMethod.GetInheritedMethods(_methodType);
                foreach (var interfaceMethod in interfacesMethod)
                {
                    methods.Add((interfaceMethod, implementationMethod));
                }
            }
            return methods;
        }
        private int[] GetIndexGenerics()
        {
            var m = _methodType;
            var mGen = m.Assembly.GetType(m.Namespace + "." + m.Name);
            var gen = mGen.GetGenericArguments();
            var argMet = mGen.GetMethods()[0].GetParameters();
            var indexGenerics = gen.Select(x =>
            {
                for (int i = 0; i < argMet.Length; i++)
                {
                    if (x == argMet[i].ParameterType)
                    {
                        return i;
                    }
                }
                return -1;
            }).ToArray();
            return indexGenerics;
        }

        #endregion

        protected IEnumerable<(Type Interface, Type Implementation)> GetMethods(params object[] argGenerics)
        {
            var typeGenerics = new List<Type>();
            foreach (var i in argGenerics)
            {
                typeGenerics.Add(i.GetType());
            }
            IEnumerable<(Type Interface, Type Implementation)> ms = _methods;
            ms = ms.FilterImplementedMethods(typeGenerics, x => x.Interface);
            ms = ms.SortGeneralizedMethods(_methodType.GetGenericsPriority(typeGenerics), x => x.Interface);
            var r = new List<(Type Interface, Type Implementation)>();
            foreach (var m in ms)
            {
                r.Add(m);
            }
            return r;
        }

        public ICallable GetMethod(params object[] argGenerics)
        {
            if (_methodType.GetInterface("IMultiMethod") != null)
            {
                var ms = GetMethods(argGenerics);
                //var m = (ms.Count() == 0) ? null : ms.First();
                var m = ms.First();
                return new MultiCall(m);
            }
            if (_methodType.GetInterface("IPolymorphicMethod") != null)
            {
                return new PolymorphicCall
                {
                    Pairs = GetMethods(argGenerics).ToList()

                };
            }
            return null;
        }
        public object Call(params object[] args)
        {
            return GetMethod(_indexGenerics.Select(x => args[x]).ToArray()).Call(args);
        }
    }

}

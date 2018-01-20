﻿using PolymorphismSharp.Extentions;
using PolymorphismSharp.Static.Methods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PolymorphismSharp.Static.Callables;

namespace PolymorphismSharp.Static.Dispatchers
{
    public abstract class _DispatcherGeneralizedMethodBase<TGeneralized, TMethod>
       where TGeneralized : class, IGeneralizedMethod
       where TMethod : TGeneralized
    {
        private List<(Type Interface, Type Implementation)> Methods { get; set; }

        #region Init
        public _DispatcherGeneralizedMethodBase()
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
    }
    public abstract class DispatcherGeneralizedMethodBase<TGeneralized, TMethod>
        : _DispatcherGeneralizedMethodBase<TGeneralized, TMethod>, IDispatcherGeneralizedMethod<TGeneralized, TMethod>
       where TGeneralized : class, IGeneralizedMethod
       where TMethod : TGeneralized
    {
        public abstract ICallable<TGeneralized> GetMethod(params object[] argGenerics);
    }
    public abstract class DispatcherGeneralizedMethodBase<TGeneralized, TMethod, TResult>
        : _DispatcherGeneralizedMethodBase<TGeneralized, TMethod>, IDispatcherGeneralizedMethod<TGeneralized, TMethod, TResult>
       where TGeneralized : class, IGeneralizedMethod
       where TMethod : TGeneralized
    {
        public abstract ICallable<TGeneralized, TResult> GetMethod(params object[] argGenerics);
    }
}

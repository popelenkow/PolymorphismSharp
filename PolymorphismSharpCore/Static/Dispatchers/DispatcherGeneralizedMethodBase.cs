using PolymorphismSharp.Extentions;
using PolymorphismSharp.Static.Methods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PolymorphismSharp.Static.Dispatchers
{
    public abstract class DispatcherGeneralizedMethodBase<TGeneralized, TMethod>
       where TGeneralized : class, IGeneralizedMethod
       where TMethod : TGeneralized
    {
        private List<KeyValueMethod<TGeneralized>> Methods { get; set; }

        #region Init
        public DispatcherGeneralizedMethodBase()
        {
            Methods = GetGeneralizedMethods();
        }
        private List<KeyValueMethod<TGeneralized>> GetGeneralizedMethods()
        {
            var methods = new List<KeyValueMethod<TGeneralized>>();
            var types = AppDomain.CurrentDomain
                                 .GetGeneralizedMethods(typeof(TMethod));

            foreach (var type in types)
            {
                TGeneralized instanceMethod = Activator.CreateInstance(type) as TGeneralized;
                IEnumerable<Type> typeMethods = type.GetInheritedMethods(typeof(TMethod));
                foreach (var typeMethod in typeMethods)
                {
                    methods.Add(new KeyValueMethod<TGeneralized>
                    {
                        TypeMethod = typeMethod,
                        InstanceMethod = instanceMethod
                    });
                }
            }
            return methods;
        }
        #endregion

        protected IEnumerable<TGeneralized> GetMethods(params object[] argGenerics)
        {
            var typeGenerics = new List<Type>();
            foreach (var i in argGenerics)
            {
                typeGenerics.Add(i.GetType());
            }
            IEnumerable<KeyValueMethod<TGeneralized>> ms = Methods;
            ms = ms.FilterImplementedMethods(typeGenerics, x => x.TypeMethod);
            ms = ms.SortGeneralizedMethods(typeof(TMethod).GetGenericsPriority(typeGenerics), x => x.TypeMethod);
            ICollection<TGeneralized> r = new List<TGeneralized>();
            foreach (var m in ms)
            {
                r.Add(m.InstanceMethod);
            }
            return r;
        }
    }
}

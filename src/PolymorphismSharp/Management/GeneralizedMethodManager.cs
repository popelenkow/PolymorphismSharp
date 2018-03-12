using System.Linq;
using PolymorphismSharp.Methods;
using PolymorphismSharp.Subtype;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using PolymorphismSharp.Extensions;

namespace PolymorphismSharp.Management
{
    class GeneralizedMethodManager : IGeneralizedMethodManager
    {
        private List<RealizationMethodInfo> _realizations;
        private Type _contractType;
        private object[] _args;
        public GeneralizedMethodManager(Type contractType, object[] args, List<RealizationMethodInfo> realizations)
        {
            _contractType = contractType;
            _realizations = realizations;
            _args = args;
        }
       
        public object Call()
        {
            if (IsNeedReturnDefault()) return ReturnDefault();
            var realization = GetPair();

            var instance = CreateInstance(realization);
            return InvokeCall(instance);
        }

        #region Private
        private int _it = 0;
        private bool IsNeedReturnDefault()
        {
            return _it == _realizations.Count;
        }

        private object ReturnDefault()
        {
            _it = 0;
            var t = _contractType.GetMethod("Call").ReturnType;
            if (t.IsValueType && t != typeof(void))
            {
                return Activator.CreateInstance(t);
            }
            return null;
        }
        private RealizationMethodInfo GetPair()
        {
            _it++;
            return _realizations[_it - 1];

        }
        private object CreateInstance(RealizationMethodInfo pair)
        {
            var instance = Activator.CreateInstance(pair.Implementation);
            Type type = null;
            type = type ?? instance.GetType().GetClass(typeof(PolymorphicMethod));
            type = type ?? instance.GetType().GetClass(typeof(PolymorphicMethod<>));

            if (type != null)
            {
                type.GetField("_nextMethod", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, this);
            }
            return instance;
        }
        private object InvokeCall(object instance)
        {
            return instance.GetType().GetMethod("Call").Invoke(instance, _args);
        }
        #endregion
    }
}

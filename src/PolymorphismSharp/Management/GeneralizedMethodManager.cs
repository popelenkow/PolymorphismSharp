
using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Management
{
    class GeneralizedMethodManager : IGeneralizedMethodManagement
    {
        private List<(Type Interface, Type Implementation)> _pairs;
        private Type _contractType;
        public object Proxy { get; set; }
        public GeneralizedMethodManager(Type contractType, List<(Type Interface, Type Implementation)> pairs)
        {
            _contractType = contractType;
            _pairs = pairs;
        }
       
        public object Call(params object[] args)
        {
            if (IsNeedReturnDefault()) return ReturnDefault();

            var pair = GetPair();
            var instance = CreateInstance(pair);

            return pair.Interface.GetMethod("Call").Invoke(instance, args);
        }

        #region Private
        private int _it = 0;
        private bool IsNeedReturnDefault()
        {
            return _it == _pairs.Count;
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
        private (Type Interface, Type Implementation) GetPair()
        {
            _it++;
            return _pairs[_it - 1];

        }
        private object CreateInstance((Type Interface, Type Implementation) pair)
        {
            var instance = Activator.CreateInstance(pair.Implementation);
            if (!(instance is MultiMethod))
            {
                instance.GetType().GetProperty("NextMethod").SetMethod.Invoke(instance, new object[] { Proxy });
            }
            return instance;
        }
        #endregion
    }
}

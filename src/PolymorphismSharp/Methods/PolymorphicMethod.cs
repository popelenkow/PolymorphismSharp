using PolymorphismSharp.Management;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Methods
{
    public class PolymorphicMethod : IGeneralizedMethod
    {
        private IGeneralizedMethodManager _nextMethod;

        public PolymorphicMethod()
        {
            _nextMethod = null;
        }

        public void CallNextMethod()
        {
            _nextMethod.Call();
        }
    }
    public class PolymorphicMethod<TResult> : IGeneralizedMethod
    {
        private IGeneralizedMethodManager _nextMethod;

        public PolymorphicMethod()
        {
            _nextMethod = null;
        }

        public TResult CallNextMethod()
        {
            return (TResult)_nextMethod.Call();
        }
    }
}

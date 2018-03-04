
using PolymorphismSharp.Methods;
using PolymorphismSharp.Parametric.Dispatchers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Management
{
    class GeneralizedMethodDispatcher : IGeneralizedMethodManagement
    {
        private IParametricDispatcher _dispatcher;
        private Type _methodType;
        private Type _proxyType;


        public GeneralizedMethodDispatcher(Type methodType, Type proxyType)
        {
            _methodType = methodType;
            _proxyType = proxyType;
            _dispatcher = new ParametricDispatcher(_methodType, proxyType);
        }

        public object _Call(params object[] args)
        {
            return _dispatcher.Call(args);
        }
    }
}

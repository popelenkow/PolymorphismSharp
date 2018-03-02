using PolymorphismSharp.Callables;
using PolymorphismSharp.Methods;
using PolymorphismSharp.Parametric.Dispatchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismSharp.Management.Dispatchers
{
    public class GeneralizedMethodDispatcher<TMethod> : IGeneralizedMethodManagement, IMultiMethod, IPolymorphicMethod
        where TMethod : class, IGeneralizedMethod
    {
        public ICallable NextMethod { get; set; }

        private IParametricDispatcher _dispatcher;
        

        public GeneralizedMethodDispatcher()
        {
            _dispatcher = new ParametricDispatcher(typeof(TMethod));
        }



        public object _Call(params object[] args)
        {
            return _dispatcher.Call(args);
        }
    }
    class MultiMethodDispatcher
    {

    }
}

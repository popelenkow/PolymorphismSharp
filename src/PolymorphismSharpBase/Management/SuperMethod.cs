using PolymorphismSharp.Callables;
using PolymorphismSharp.Methods;
using PolymorphismSharp.Parametric.Dispatchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismSharp.Management
{
    class SuperMultiMethod<TMethod> : ICallable
        where TMethod : class, IMultiMethod
    {
        private DispatcherGeneralizedMethod<TMethod> _dispatcher;
        private int[] _indexGenerics;

        public SuperMultiMethod()
        {
            var m = typeof(TMethod);
            var mGen = m.Assembly.GetType(m.Namespace + "." + m.Name);
            var gen = mGen.GetGenericArguments();
            var argMet = mGen.GetMethods()[0].GetParameters();
            _indexGenerics = gen.Select(x =>
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
            _dispatcher = new DispatcherGeneralizedMethod<TMethod>();

        }
        public object Call(params object[] args)
        {
            return _dispatcher.GetMethod(_indexGenerics.Select(x => args[x]).ToArray()).Call(args);
        }
    }

    class SuperPolymorphicMethod<TMethod> : ICallable
        where TMethod : class, IPolymorphicMethod
    {
        public object Call(params object[] args)
        {
            throw new NotImplementedException();
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Parameters;

namespace Sample.MethodDo12
{
    public abstract class MethodDo12<TParameter1, TParameter2> : MultiAction<TParameter1, TParameter2, int>
        where TParameter1 : A1
        where TParameter2 : A2
    {
    }

    static class MethodDo12Extensions
    {
        private static MethodDo12<A1, A2> _contract;
        static MethodDo12Extensions()
        {
            _contract = GeneralizedMethodBuilder.GetContract<MethodDo12<A1, A2>>();
        }
        public static void Do12(this A1 parameter1, A2 parameter2, int arg)
        {
            _contract.Call(parameter1, parameter2, arg);
        }
    }
}

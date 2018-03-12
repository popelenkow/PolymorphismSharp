using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Parameters;

namespace Sample.MethodDo21
{
    public abstract class MethodDo21<TParameter2, TParameter1> : MultiAction<TParameter1, TParameter2, int>
        where TParameter1 : A1
        where TParameter2 : A2
    {
    }

    static class MethodDo21Extensions
    {
        private static MethodDo21<A2, A1> _contract;
        static MethodDo21Extensions()
        {
            _contract = GeneralizedMethodBuilder.GetContract<MethodDo21<A2, A1>>();
        }
        public static void Do21(this A1 parameter1, A2 parameter2, int arg)
        {
            _contract.Call(parameter1, parameter2, arg);
        }
    }
}

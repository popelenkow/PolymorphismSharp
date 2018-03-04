using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    public static class MethodDoExtensions
    {
        private static MethodDo<A> _contract;
        static MethodDoExtensions()
        {
            _contract = PolymorphicMethodBuilder.GetContract<MethodDo<A>>();
        }
        public static void Do(this A parameter, params object[] args)
        {
            _contract.Call(parameter, args);
        }
    }
}

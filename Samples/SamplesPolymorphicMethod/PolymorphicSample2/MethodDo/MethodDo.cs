using Sample.Parameters;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    public abstract class MethodDo<TParameter> : PolymorphicAction<TParameter, object[]>
        where TParameter : A
    {
    }
    public static class MethodDoExtensions
    {
        private static MethodDo<A> _contract;
        static MethodDoExtensions()
        {
            _contract = GeneralizedMethodBuilder.GetContract<MethodDo<A>>();
        }
        public static void Do(this A parameter, params object[] args)
        {
            _contract.Call(parameter, args);
        }
    }
}

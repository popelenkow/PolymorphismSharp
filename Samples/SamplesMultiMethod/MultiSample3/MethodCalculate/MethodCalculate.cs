using Sample.Parameters;
using PolymorphismSharp.Methods;

namespace Sample.MethodCalculate
{ 
    public abstract class MethodCalculate<TParameter> : MultiFunc<TParameter, int, float, string, double>
        where TParameter : A
    {
    }
    public static class MethodCalculateExtensions
    {
        private static MethodCalculate<A> _contract;
        static MethodCalculateExtensions()
        {
            _contract = GeneralizedMethodBuilder.GetContract<MethodCalculate<A>>();
        }
        public static double Calculate(this A parameter, int arg1, float arg2, string arg3)
        {
            return _contract.Call(parameter, arg1, arg2, arg3);
        }
    }
}

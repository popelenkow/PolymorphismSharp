using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodCalculate
{
    public static class MethodCalculateExtensions
    {
        private static MethodCalculate<A> _contract;
        static MethodCalculateExtensions()
        {
            _contract = MultiMethodBuilder.GetContract<MethodCalculate<A>>();
        }
        public static double Calculate(this A parameter, int arg1, float arg2, string arg3)
        {
            return _contract.Call(arg3, arg1, parameter, arg2);
        }
    }
}

using PolymorphismSharp.Methods;
using PolymorphismSharp.Parametric.Dispatchers;
using Sample.Models;

namespace Sample.MethodCalculate
{
    public static class ExtentionsMethodCalculate
    {
        private static IMethodCalculate<A> _method;
        static ExtentionsMethodCalculate()
        {
            _method = GeneralizedMethodBuilder.GetMultiMethod<IMethodCalculate<A>>();
        }
        public static double Calculate(this A model, int arg1, float arg2, string arg3)
        {
            return _method.Call(arg3, arg1, model, arg2);
        }
    }
}

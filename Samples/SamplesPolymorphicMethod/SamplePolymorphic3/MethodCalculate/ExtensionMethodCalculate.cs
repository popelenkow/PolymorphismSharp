using PolymorphismSharp.Methods.Builder;
using Sample.Models;

namespace Sample.MethodCalculate
{
    public static class ExtensionMethodCalculate
    {
        private static IMethodCalculate<A> _method;
        static ExtensionMethodCalculate()
        {
            _method = PolymorphicMethodBuilder.GetMethod<IMethodCalculate<A>>();
        }
        public static double Calculate(this A model, int arg1, float arg2, string arg3)
        {
            return _method.Call(arg3, arg1, model, arg2);
        }
    }
}

using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodCalculate
{
    public static class ExtensionMethodCalculate
    {
        private static MethodCalculate<A> _method;
        static ExtensionMethodCalculate()
        {
            _method = PolymorphicMethodBuilder.GetMethod<MethodCalculate<A>>();
        }
        public static double Calculate(this A model, int arg1, float arg2, string arg3)
        {
            return _method.Call(arg3, arg1, model, arg2);
        }
    }
}

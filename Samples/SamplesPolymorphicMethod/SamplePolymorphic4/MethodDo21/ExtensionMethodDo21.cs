using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo21
{
    static class ExtensionMethodDo21
    {
        private static MethodDo21<A2, A1> _method;
        static ExtensionMethodDo21()
        {
            _method = PolymorphicMethodBuilder.GetMethod<MethodDo21<A2, A1>>();
        }
        public static void Do21(this A1 model1, A2 model2, int arg)
        {
            _method.Call(model2, arg, model1);
        }
    }
}

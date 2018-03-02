using Sample.Models;
using PolymorphismSharp.Methods.Builder;

namespace Sample.MethodDo12
{
    static class ExtensionMethodDo12
    {
        private static IMethodDo12<A1, A2> _method;
        static ExtensionMethodDo12()
        {
            _method = PolymorphicMethodBuilder.GetMethod<IMethodDo12<A1, A2>>();
        }
        public static void Do12(this A1 model1, A2 model2, int arg)
        {
            _method.Call(model2, arg, model1);
        }
    }
}

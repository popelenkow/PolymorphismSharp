using PolymorphismSharp.Methods.Builder;
using Sample.Models;


namespace Sample.MethodDo21
{
    static class ExtensionMethodDo21
    {
        private static IMethodDo21<A2, A1> _method;
        static ExtensionMethodDo21()
        {
            _method = MultiMethodBuilder.GetMethod<IMethodDo21<A2, A1>>();
        }
        public static void Do21(this A1 model1, A2 model2, int arg)
        {
            _method.Call(model2, arg, model1);
        }
    }
}

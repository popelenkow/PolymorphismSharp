using PolymorphismSharp.Methods.Builder;
using Sample.Models;

namespace Sample.MethodDo
{
    public static class ExtensionMethodDo
    {
        private static IMethodDo<A> _method;
        static ExtensionMethodDo()
        {
            _method = PolymorphicMethodBuilder.GetMethod<IMethodDo<A>>();
        }
        public static void Do(this A model, params object[] args)
        {
            _method.Call(model, args);
        }
    }
}

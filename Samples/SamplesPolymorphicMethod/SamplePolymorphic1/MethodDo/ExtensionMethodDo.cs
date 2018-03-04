using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo
{
    public static class ExtensionMethodDo
    {
        private static MethodDo<A> _method;
        static ExtensionMethodDo()
        {
            _method = PolymorphicMethodBuilder.GetMethod<MethodDo<A>>();
        }
        public static void Do(this A model, params object[] args)
        {
            _method.Call(model, args);
        }
    }
}

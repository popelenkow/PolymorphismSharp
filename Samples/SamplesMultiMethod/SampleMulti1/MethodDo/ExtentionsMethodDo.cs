using PolymorphismSharp.Callables;
using PolymorphismSharp.Methods;
using PolymorphismSharp.Parametric.Dispatchers;
using Sample.Models;

namespace Sample.MethodDo
{
    public static class ExtentionsMethodDo
    {
        private static IMethodDo<A> _method;
        static ExtentionsMethodDo()
        {
            _method = GeneralizedMethodBuilder.GetMultiMethod<IMethodDo<A>>();
        }
        public static void Do(this A model, params object[] args)
        {
            _method.Call(model, args);
        }
    }
}

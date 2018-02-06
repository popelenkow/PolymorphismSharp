using PolymorphismSharp.Static.Dispatchers;
using Sample.Models;

namespace Sample.MethodDo
{
    public static class ExtentionsMethodDo
    {
        private static DispatcherPolymorphicMethod<IMethodDo<A>> dispatcher { get; set; }
        static ExtentionsMethodDo()
        {
            dispatcher = new DispatcherPolymorphicMethod<IMethodDo<A>>();
        }
        public static void Do(this A model, params object[] args)
        {
            dispatcher.GetMethod(model)
                      .Call(model, args);
        }
    }
}

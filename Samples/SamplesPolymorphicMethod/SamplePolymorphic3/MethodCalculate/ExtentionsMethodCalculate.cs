using PolymorphismSharp.Static.Dispatchers;
using Sample.Models;

namespace Sample.MethodCalculate
{
    public static class ExtentionsMethodCalculate
    {
        private static DispatcherPolymorphicMethod<IMethodCalculate<A>, double> dispatcher { get; set; }
        static ExtentionsMethodCalculate()
        {
            dispatcher = new DispatcherPolymorphicMethod<IMethodCalculate<A>, double>();
        }
        public static double Calculate(this A model, int arg1, float arg2, string arg3)
        {
            return dispatcher.GetMethod(model)
                             .Call(arg3, arg1, model, arg2);
        }
    }
}

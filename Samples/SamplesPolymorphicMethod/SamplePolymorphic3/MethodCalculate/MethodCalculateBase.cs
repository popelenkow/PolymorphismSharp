using Sample.Models;
using PolymorphismSharp.Methods;
using PolymorphismSharp.Callables;

namespace Sample.MethodCalculate
{
    public abstract class MethodCalculateBase<TModel> : PolymorphicMethod, IMethodCalculate<TModel>
        where TModel : A
    {
        public abstract double Call(string arg3, int arg1, TModel model, float arg2);
    }
}

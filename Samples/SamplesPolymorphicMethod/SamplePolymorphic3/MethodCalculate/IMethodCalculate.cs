using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodCalculate
{
    public interface IMethodCalculate<TModel> : IPolymorphicMethod
        where TModel : A
    {
        double Call(string arg3, int arg1, TModel model, float arg2);
    }
}

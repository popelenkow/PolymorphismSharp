using Sample.Models;
using PolymorphismSharp.Static.Methods;

namespace Sample.MethodCalculate
{ 
    public abstract class MethodCalculateBase<TModel> : MultiMethod, IMethodCalculate<TModel>
        where TModel : A
    {
        public abstract double Call(string arg3, int arg1, TModel model, float arg2);
    }
}

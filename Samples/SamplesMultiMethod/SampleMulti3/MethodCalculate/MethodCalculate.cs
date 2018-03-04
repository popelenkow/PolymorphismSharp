using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodCalculate
{ 
    public abstract class MethodCalculate<TModel> : MultiMethod
        where TModel : A
    {
        public abstract double Call(string arg3, int arg1, TModel model, float arg2);
    }
}

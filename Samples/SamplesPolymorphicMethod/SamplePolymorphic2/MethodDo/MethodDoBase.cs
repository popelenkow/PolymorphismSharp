using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    public abstract class MethodDoBase<TModel> : PolymorphicMethod, IMethodDo<TModel>
        where TModel : A
    {
        public abstract void Call(TModel model, params object[] args);
    }
}

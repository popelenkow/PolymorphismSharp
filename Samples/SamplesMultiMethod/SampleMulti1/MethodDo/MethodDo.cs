using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    public abstract class MethodDo<TModel> : MultiMethod
        where TModel : A
    {
        public abstract void Call(TModel model, params object[] args);
    }
}

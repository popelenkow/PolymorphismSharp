using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    public abstract class MethodDo<TModel> : PolymorphicMethod<MethodDo<A>>
        where TModel : A
    {
        public abstract void Call(TModel model, params object[] args);
    }
}

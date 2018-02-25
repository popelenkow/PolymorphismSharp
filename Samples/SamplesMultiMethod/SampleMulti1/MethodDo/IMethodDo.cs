using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo
{
    public interface IMethodDo<TModel> : IMultiMethod
        where TModel : A
    {
        void Call(TModel model, params object[] args);
    }
}

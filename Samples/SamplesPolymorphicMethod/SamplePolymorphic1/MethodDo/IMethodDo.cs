using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo
{
    public interface IMethodDo<TModel> : IPolymorphicMethod
        where TModel : A
    {
        void Call(TModel model, params object[] args);
    }
}

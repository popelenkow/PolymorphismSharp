using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    public abstract class MethodDo<TParameter> : MultiMethod
        where TParameter : A
    {
        public abstract void Call(TParameter parameter, params object[] args);
    }
}

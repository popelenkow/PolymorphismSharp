using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo12
{
    static class MethodDo12Extensions
    {
        private static MethodDo12<A1, A2> _contract;
        static MethodDo12Extensions()
        {
            _contract = PolymorphicMethodBuilder.GetContract<MethodDo12<A1, A2>>();
        }
        public static void Do12(this A1 parameter1, A2 parameter2, int arg)
        {
            _contract.Call(parameter2, arg, parameter1);
        }
    }
}

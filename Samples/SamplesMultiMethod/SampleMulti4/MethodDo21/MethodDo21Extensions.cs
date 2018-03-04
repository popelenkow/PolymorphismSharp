using PolymorphismSharp.Methods;
using Sample.Models;


namespace Sample.MethodDo21
{
    static class MethodDo21Extensions
    {
        private static MethodDo21<A2, A1> _contract;
        static MethodDo21Extensions()
        {
            _contract = MultiMethodBuilder.GetContract<MethodDo21<A2, A1>>();
        }
        public static void Do21(this A1 parameter1, A2 parameter2, int arg)
        {
            _contract.Call(parameter2, arg, parameter1);
        }
    }
}

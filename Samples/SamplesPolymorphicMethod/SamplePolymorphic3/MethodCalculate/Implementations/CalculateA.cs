using System;
using Sample.Models;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateA : MethodCalculate<A>
    {
        public override double Call(string arg3, int arg1, A model, float arg2)
        {
            return arg1 + NextMethod.Call(arg3, arg1, model, arg2);
        }
    }
}

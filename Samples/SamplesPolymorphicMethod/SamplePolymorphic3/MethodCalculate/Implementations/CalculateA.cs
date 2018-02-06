using System;
using Sample.Models;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateA : MethodCalculateBase<A>
    {
        public override double Call(string arg3, int arg1, A model, float arg2)
        {
            return arg1 + CallNextMethod();
        }
    }
}

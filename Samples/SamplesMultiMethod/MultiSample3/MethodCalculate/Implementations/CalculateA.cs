using System;
using Sample.Parameters;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateA : MethodCalculate<A>
    {
        public override double Call(A parameter, int arg1, float arg2, string arg3)
        {
            return arg1;
        }
    }
}

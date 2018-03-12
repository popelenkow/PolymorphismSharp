using System;
using Sample.Parameters;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateB : MethodCalculate<B>
    {
        public override double Call(B parameter, int arg1, float arg2, string arg3)
        {
            return arg2;
        }
    }
}
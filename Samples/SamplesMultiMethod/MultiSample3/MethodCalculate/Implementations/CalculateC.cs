using System;
using Sample.Parameters;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateC : MethodCalculate<C>
    {
        public override double Call(C parameter, int arg1, float arg2, string arg3)
        {
            return arg3.Length;
        }
    }
}
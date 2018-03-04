using System;
using Sample.Models;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateB : MethodCalculate<B>
    {
        public override double Call(string arg3, int arg1, B model, float arg2)
        {
            return arg2;
        }
    }
}
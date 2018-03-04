using System;
using Sample.Models;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateC : MethodCalculate<C>
    {
        public override double Call(string arg3, int arg1, C model, float arg2)
        {
            return arg3.Length;
        }
    }
}
using System;
using Sample.Models;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateB : MethodCalculateBase<B>
    {
        public override double Call(string arg3, int arg1, B model, float arg2)
        {
            int a1 = -10;
            float a2 = 3.14f;
            string a3 = "arg3";
            return arg2 + CallNextMethod(a3, a1, model, a2);
        }
    }
}
using System;
using Sample.Models;

namespace Sample.MethodCalculate.Implementations
{
    public class CalculateB : MethodCalculate<B>
    {
        public override double Call(string arg3, int arg1, B parameter, float arg2)
        {
            int a1 = -10;
            float a2 = 3.14f;
            string a3 = "arg3";
            return arg2 + NextMethod.Call(a3, a1, parameter, a2);
        }
    }
}
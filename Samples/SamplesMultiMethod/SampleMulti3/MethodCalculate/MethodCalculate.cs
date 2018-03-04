﻿using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodCalculate
{ 
    public abstract class MethodCalculate<TParameter> : MultiMethod
        where TParameter : A
    {
        public abstract double Call(string arg3, int arg1, TParameter parameter, float arg2);
    }
}

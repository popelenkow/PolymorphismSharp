﻿using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoCB : PolymorphicMethod, IMethodDo<CB>
    {
        public void Call(CB model, params object[] args)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            NextMethod.Call(model, args);
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}
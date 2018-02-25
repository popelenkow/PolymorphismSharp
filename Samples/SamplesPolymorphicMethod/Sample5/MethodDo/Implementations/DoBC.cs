﻿using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoBC : MethodDoBase<BC>
    {
        public override void Call(BC model, params object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name + "before");
            NextMethod.Call(model, args);
            Console.WriteLine("Method " + this.GetType().Name + "after");
        }
    }
}
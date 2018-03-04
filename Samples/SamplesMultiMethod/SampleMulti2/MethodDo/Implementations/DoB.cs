﻿using System;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    public class DoB : MethodDo<B>
    {
        public override void Call(B model, params object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}

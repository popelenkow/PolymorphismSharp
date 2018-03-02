﻿using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo12.Implementations
{
    class DoA1B2 : MethodDo12Base<A1, B2>
    {
        public override void Call(B2 model2, int arg, A1 model1)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}

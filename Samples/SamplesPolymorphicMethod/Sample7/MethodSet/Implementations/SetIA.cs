﻿using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodSet.Implementations
{
    class SetIA : PolymorphicMethod, IMethodSet<IA>
    {
        public void Call(IA model, int arg)
        {
            model.PropertyA = arg + 5;
            Console.WriteLine(model.GetType().Name + " call before " + this.GetType().Name);
            NextMethod.Call(model, arg);
            Console.WriteLine(model.GetType().Name + " call after " + this.GetType().Name);
        }
    }
}

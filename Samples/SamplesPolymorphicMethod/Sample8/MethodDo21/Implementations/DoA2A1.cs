﻿using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo21.Implementations
{
    class DoA2A1 : PolymorphicMethod, IMethodDo21<A2, A1>
    {
        public void Call(A2 model2, int arg, A1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call before " + this.GetType().Name);
            NextMethod.Call(model2, arg, model1);
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call after " + this.GetType().Name);
        }
    }
}
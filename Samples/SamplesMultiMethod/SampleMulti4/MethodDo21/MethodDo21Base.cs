﻿using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo21
{
    abstract class MethodDo21Base<TModel2, TModel1> : MultiMethod, IMethodDo21<TModel2, TModel1>
        where TModel1 : A1
        where TModel2 : A2
    {
        public abstract void Call(TModel2 model2, int arg, TModel1 model1);
    }
}

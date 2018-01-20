﻿using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodRead
{
    interface IMethodRead<TModel> : IPolymorphicMethod<string>
        where TModel : IA
    {
        string Call(TModel model);
    }
}
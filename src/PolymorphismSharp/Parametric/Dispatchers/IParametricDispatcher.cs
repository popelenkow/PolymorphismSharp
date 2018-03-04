﻿using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Parametric.Extensions;
using System.Linq;
using PolymorphismSharp.Methods;


namespace PolymorphismSharp.Parametric.Dispatchers
{
    interface IParametricDispatcher
    {
        object Call(params object[] args);
    }

}
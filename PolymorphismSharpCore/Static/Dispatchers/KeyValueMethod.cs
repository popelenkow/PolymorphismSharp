using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;

namespace PolymorphismSharp.Static.Dispatchers
{
    struct KeyValueMethod<TMethod>
        where TMethod : IGeneralizedMethod
    {
        public Type TypeMethod;
        public TMethod InstanceMethod;
    }
}

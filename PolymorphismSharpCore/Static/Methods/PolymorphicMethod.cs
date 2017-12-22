using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Static.Methods
{
    public class PolymorphicMethod : IPolymorphicMethod
    {
        public bool CallNextMethod { get; set; }
    }
    public class PolymorphicMethod<TResult> : IPolymorphicMethod<TResult>
    {
        public bool CallNextMethod { get; set; }
        public TResult Result { get; set; }
    }
}

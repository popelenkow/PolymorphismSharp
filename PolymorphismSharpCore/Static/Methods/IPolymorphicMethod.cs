using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Static.Methods
{
    public interface IPolymorphicMethod : IGeneralizedMethod
    {
        bool CallNextMethod { get; set; }
    }
    public interface IPolymorphicMethod<TResult> : IGeneralizedMethod
    {
        bool CallNextMethod { get; set; }
        TResult Result { get; set; }
    }
}

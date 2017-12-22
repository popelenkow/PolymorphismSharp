using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;
using Sample.Args;
using Sample.Results;

namespace Sample.MethodDo.Implementations
{
    class DoIA : PolymorphicMethod<IResult>, IMethodDo<IA>
    {
        public void Before(IA model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            this?.Result.Strings.Add("Before " + this.GetType().Name + " with args " + arg.String);
        }
        public void After(IA model, IArg arg)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
            this?.Result.Strings.Add("After " + this.GetType().Name + " with args " + arg.String);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;
using Sample.Args;
using Sample.Results;

namespace Sample.MethodDo.Implementations
{
    class DoA : PolymorphicMethod<IResult>, IMethodDo<A>
    {
        public void Before(A model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            if (this.Result == null)
            {
                this.Result = new Result();
            }
            arg.String += "A";
        }
        public void After(A model, IArg arg)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;
using Sample.Args;
using Sample.Results;

namespace Sample.MethodDo.Implementations
{
    class DoB : PolymorphicMethod<IResult>, IMethodDo<B>
    {
        public void Before(B model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            if (this.Result == null)
            {
                this.Result = new Result();
            }
            arg.String += "B";
        }
        public void After(B model, IArg arg)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}
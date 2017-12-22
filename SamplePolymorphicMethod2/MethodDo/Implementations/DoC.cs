using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;
using Sample.Args;
using Sample.Results;

namespace Sample.MethodDo.Implementations
{
    class DoC : PolymorphicMethod<IResult>, IMethodDo<C>
    {
        public void Before(C model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            if (this.Result == null)
            {
                this.Result = new Result();
            }
            arg.String += "C";
        }
        public void After(C model, IArg arg)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
            
        }
    }
}
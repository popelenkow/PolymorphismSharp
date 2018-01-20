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
        public IResult Call(B model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            
            arg.String += "B";
            IResult result = CallNextMethod();
            if (result == null)
            {
                result = new Result();
            }
            Console.WriteLine("After: method " + this.GetType().Name);
            return result;
        }
    }
}
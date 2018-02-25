using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;
using Sample.Args;
using Sample.Results;

namespace Sample.MethodDo.Implementations
{
    class DoA : PolymorphicMethod, IMethodDo<A>
    {
        public IResult Call(A model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);

            arg.String += "A";
            IResult result = NextMethod.Call(model, arg) as IResult;
            if (result == null)
            {
                result = new Result();
            }
            Console.WriteLine("After: method " + this.GetType().Name);
            return result;
        }
    }
}
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
        public IResult Call(A model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);

            arg.String += "A";
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
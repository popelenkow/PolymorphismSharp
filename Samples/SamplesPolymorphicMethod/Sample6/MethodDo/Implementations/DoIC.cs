using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;
using Sample.Args;
using Sample.Results;

namespace Sample.MethodDo.Implementations
{
    class DoIC : PolymorphicMethod, IMethodDo<IC>
    {
        public IResult Call(IC model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            IResult result = NextMethod.Call(model, arg) as IResult;
            if (result == null)
            {
                result = new Result();
            }
            result.Strings.Add("After " + this.GetType().Name + " with args " + arg.String);
            Console.WriteLine("After: method " + this.GetType().Name);
            return result;
        }
    }
}

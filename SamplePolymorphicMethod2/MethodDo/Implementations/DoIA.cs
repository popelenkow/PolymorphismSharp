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
        public IResult Call(IA model, IArg arg)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            IResult result = CallNextMethod();
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

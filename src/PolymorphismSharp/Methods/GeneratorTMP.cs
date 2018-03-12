using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Methods
{
    /*
      for (int count = 2; count < 17; count++)
            {
                List<int> arr = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    arr.Add(i + 1);
                }
                string Gens = arr.Select(x => "TArg" + x.ToString()).Aggregate((current, next) => current + ", " + next);
                string Args = arr.Select(x => "TArg" + x.ToString() + " arg" + x.ToString()).Aggregate((current, next) => current + ", " + next);
                string ss = @"public abstract class MultiAction<" + Gens + @"> : IGeneralizedMethod
{
    public virtual bool Pre(" + Args + @") => true;
    public virtual bool Post(" + Args + @") => true;
    public abstract void Call(" + Args + @");
}";
               
                Console.WriteLine(ss);
            }
    */
}

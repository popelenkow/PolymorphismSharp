using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PolymorphismSharp.Methods
{
    public class Derive<TDerives>
        where TDerives : struct, ITuple
    {
    }
}

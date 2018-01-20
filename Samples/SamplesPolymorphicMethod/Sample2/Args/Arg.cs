using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Args
{
    class Arg : IArg
    {
        public string String { get; set; }
        public Arg()
        {
            String = string.Empty;
        }
    }
}

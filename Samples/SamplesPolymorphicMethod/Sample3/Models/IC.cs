using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Models
{
    interface IC : IB
    {
        int PropertyC { get; set; }
    }
}

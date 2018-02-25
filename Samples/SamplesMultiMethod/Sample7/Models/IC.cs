using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Models
{
    public interface IC : IB
    {
        int PropertyC { get; set; }
    }
}

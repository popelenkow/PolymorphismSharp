using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Models
{
    interface IB : IA
    {
        int PropertyB { get; set; }
    }
}

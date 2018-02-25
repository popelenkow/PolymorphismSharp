using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Models
{
    public interface IB : IA
    {
        int PropertyB { get; set; }
    }
}

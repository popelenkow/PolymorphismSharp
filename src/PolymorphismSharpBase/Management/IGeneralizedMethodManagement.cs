using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Management
{
    interface IGeneralizedMethodManagement
    {
        object _Call(params object[] args);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Management.Dispatchers
{
    abstract class GeneralizedMethodDispatcher : IGeneralizedMethodManagement
    {
        public abstract object _Call(params object[] args);
    }
}

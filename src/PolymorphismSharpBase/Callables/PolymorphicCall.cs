using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PolymorphismSharp.Methods;

namespace PolymorphismSharp.Callables
{
    class PolymorphicCall : IPolymorphicCall
    {
        public List<(Type Interface, Type Implementation)> Pairs { get; set; }

        private int _it { get; set; } = 0;

        public object Call(params object[] args)
        {
            if (_it == Pairs.Count)
            {
                _it = 0;
                // ToDo
                var t = Pairs[0].Interface.GetMethod("Call").ReturnType;
                if (t.IsValueType && t != typeof(void))
                {
                    return Activator.CreateInstance(t);
                }
                return null;
            }
            var pair = Pairs[_it];
            _it++;
            var instance = Activator.CreateInstance(pair.Implementation) as IPolymorphicMethod;
            instance.NextMethod = this;
            return pair.Interface.GetMethod("Call").Invoke(instance, args);
        }
    }
}

using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismSharp.Extensions
{
    static class TypeExtensions
    {
        public static bool EqualsGeneralization(this Type x, Type y)
        {
            if (x.IsGenericType)
            {
                x = x.GetGenericTypeDefinition();
            }
            if (y.IsGenericType)
            {
                y = y.GetGenericTypeDefinition();
            }
            return x == y;
        }
        
        public static Type GetClass(this Type x, Type y)
        {
            while (x != null)
            {
                if (x.EqualsGeneralization(y)) break;
                x = x.BaseType;
            }
            return x;
        }
        



        public static IEnumerable<Type> GetClassesAndInterfaces(this Type type, Type typeBase = null)
        {
            if (type.BaseType == null) return type.GetInterfaces().ToArray();

            List<Type> arrClasses = new List<Type>();
            Type typeCur = type;
            while (true)
            {
                arrClasses.Insert(0, typeCur);
                if (typeCur.BaseType == null) break;
                typeCur = typeCur.BaseType;
            }

            List<Type> arrResults = new List<Type>();
            foreach (var t in arrClasses)
            {
                var arrInterfaces = t.GetInterfaces().Where(x => !arrResults.Contains(x)).ToList();
                var arrBuf = new List<Type>();

                foreach (var ti in arrInterfaces)
                {
                    while (arrBuf.Count > 0)
                    {
                        var last = arrBuf.Last();
                        if (!ti.IsAssignableFrom(last))
                        {
                            arrBuf.RemoveAt(arrBuf.Count - 1);
                            arrResults.Add(last);
                        }
                        else
                        {
                            break;
                        }
                    }
                    arrBuf.Add(ti);
                }
                arrBuf.Reverse();
                foreach (var buf in arrBuf)
                {
                    arrResults.Add(buf);
                }
                arrResults.Add(t);
            }
            arrResults.Reverse();
            if (typeBase != null)
            {
                return arrResults.Where(x => typeBase.IsAssignableFrom(x)).ToList();
            }
            return arrResults.ToList();
        }
    }
}

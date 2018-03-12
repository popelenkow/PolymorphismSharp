using PolymorphismSharp.Methods;
using PolymorphismSharp.Reflection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PolymorphismSharp.Extensions
{
    static class AppDomainExtensions
    {
        public static List<RealizationMethodInfo> GetGeneralizedMethods(this AppDomain appDomain, Type contractType)
        {
            List<RealizationMethodInfo> realizations = new List<RealizationMethodInfo>();
            Assembly[] assemblies = appDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                if (assembly == ILMethodGenerator.Assembly) continue;
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    var interfaceType = type.BaseType.GetClass(contractType);
                    if (interfaceType != null)
                    {
                        realizations.Add((interfaceType, type));
                    }
                }
            }
            return realizations;
        }
        
        public static List<Type> GetDerived(this AppDomain appDomain)
        {
            List<Type> derives = new List<Type>();
            Assembly[] assemblies = appDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                if (assembly == ILMethodGenerator.Assembly) continue;
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    var t = type.BaseType.GetClass(typeof(Derive<>));
                    if (t != null)
                    {
                        derives.Add(t);
                    }
                }
            }
            return derives;
        }
        
    }
}

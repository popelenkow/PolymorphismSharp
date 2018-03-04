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
        public static List<(Type Interface, Type Implementation)> GetGeneralizedMethods(this AppDomain appDomain, Type contractType)
        {
            List<(Type Interface, Type Implementation)> realizations = new List<(Type Interface, Type Implementation)>();
            Assembly[] assemblies = appDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                if (assembly == ILMethodGenerator.Assembly) continue;
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    //if (typeof(IGeneralizedMethod).IsAssignableFrom(type))
                    //{
                        var r = type.ExtractInterface(contractType);
                        if (r != null)
                        {
                            realizations.Add(r.Value);
                        }
                        
                    //}
                }
            }
            return realizations;
        }
    }
}

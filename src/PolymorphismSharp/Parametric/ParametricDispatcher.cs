﻿using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PolymorphismSharp.Management;
using PolymorphismSharp.Extensions;

namespace PolymorphismSharp.Parametric
{
    class ParametricDispatcher : IParametricDispatcher
    {
        private Type _contractType;
        private int[] _indexParameters;

        public ParametricDispatcher(Type contractType)
        {
            _contractType = contractType;
            _indexParameters = GetIndexParameters();
        }

        private int[] GetIndexParameters()
        {
            var m = _contractType;
            var mGen = m.Assembly.GetType(m.Namespace + "." + m.Name);
            var gen = mGen.GetGenericArguments();
            var argMet = mGen.GetMethods()[0].GetParameters();
            var indexGenerics = gen.Select(x =>
            {
                for (int i = 0; i < argMet.Length; i++)
                {
                    if (x == argMet[i].ParameterType)
                    {
                        return i;
                    }
                }
                return -1;
            }).ToArray();
            return indexGenerics;
        }

        private IEnumerable<Type> GetParametersFrom(object[] args)
        {
            return _indexParameters.Select(x => args[x].GetType());
        }
        public IComparer<Type> GetRealizationComparer(object[] args)
        {
            return new InterfaceComparer(GetParametersFrom(args));
        }
        public Predicate<Type> GetRealizationFilter(object[] args)
        {
            return InterfaceFilter.Get(_contractType, GetParametersFrom(args));
        }
    }

}

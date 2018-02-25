using PolymorphismSharp.Callables;
using PolymorphismSharp.Management;
using PolymorphismSharp.Parametric.Dispatchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace PolymorphismSharp.Methods
{
    public class GeneralizedMethodDispatcher<TMethod> : IMultiMethod, IPolymorphicMethod
        where TMethod : class, IGeneralizedMethod
    {
        public ICallable NextMethod { get; set; }


        private IDispatcherGeneralizedMethod<TMethod> _dispatcher;
        private int[] _indexGenerics;

        public GeneralizedMethodDispatcher()
        {
            var m = typeof(TMethod);
            var mGen = m.Assembly.GetType(m.Namespace + "." + m.Name);
            var gen = mGen.GetGenericArguments();
            var argMet = mGen.GetMethods()[0].GetParameters();
            _indexGenerics = gen.Select(x =>
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
            _dispatcher = new DispatcherGeneralizedMethod<TMethod>();
        }

      

        public object CallDispatch(params object[] args)
        {
            return _dispatcher.GetMethod(_indexGenerics.Select(x => args[x]).ToArray()).Call(args);
        }
    }

  
    public static class ILMethodGenerator
    {
        private static AssemblyName _aName = new AssemblyName("DynamicAssemblyPolymorphismSharp");
        private static AssemblyBuilder _ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(Guid.NewGuid().ToString()), AssemblyBuilderAccess.Run);
        private static ModuleBuilder _mb = _ab.DefineDynamicModule(_aName.Name);
        public static Assembly Assembly { get; } = _ab;

        public static (Type Dispatcher, Type Manager) Generate<TMethod>()
            where TMethod : class, IGeneralizedMethod
        {
            var interfaceType = typeof(TMethod);
            var interfaceMethod = interfaceType.GetMethod("Call");
            var interfaceMethodArgs = interfaceMethod.GetParameters().Select(x => x.ParameterType).ToArray();
            var returnType = interfaceMethod.ReturnType;
            var classType = typeof(GeneralizedMethodDispatcher<TMethod>);
            var classMethod = classType.GetMethod("CallDispatch");
            var baseType = classType;
            var baseConstructor = baseType.GetConstructor(BindingFlags.Public | BindingFlags.FlattenHierarchy | BindingFlags.Instance, null, Type.EmptyTypes, null);


            TypeBuilder tb = _mb.DefineType("Generated" + interfaceType.Name + "Dispatcher " + Guid.NewGuid().ToString(), TypeAttributes.Public, baseType);


            ConstructorBuilder ctor = tb.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, Type.EmptyTypes);
            ILGenerator ctorIL = ctor.GetILGenerator();
            ctorIL.Emit(OpCodes.Ldarg_0);
            ctorIL.Emit(OpCodes.Call, baseConstructor);
            ctorIL.Emit(OpCodes.Nop);
            ctorIL.Emit(OpCodes.Nop);
            ctorIL.Emit(OpCodes.Ret);


            tb.AddInterfaceImplementation(interfaceType);

            MethodBuilder mbIM = tb.DefineMethod(interfaceType.Name + "." + interfaceMethod.Name,
                MethodAttributes.Private | MethodAttributes.HideBySig |
                MethodAttributes.NewSlot | MethodAttributes.Virtual |
                MethodAttributes.Final,
                returnType,
                interfaceMethodArgs);
            ILGenerator genIM = mbIM.GetILGenerator();
            genIM.Emit(OpCodes.Ldarg, 0);
            genIM.Emit(OpCodes.Ldc_I4, interfaceMethodArgs.Length);
            genIM.Emit(OpCodes.Newarr, typeof(object));

            for (int i = 0; i < interfaceMethodArgs.Length; i++)
            {
                genIM.Emit(OpCodes.Dup);
                genIM.Emit(OpCodes.Ldc_I4, i);
                genIM.Emit(OpCodes.Ldarg, i + 1);
                if (interfaceMethodArgs[i].IsValueType)
                {
                    genIM.Emit(OpCodes.Box, interfaceMethodArgs[i]);
                }
                genIM.Emit(OpCodes.Stelem_Ref);
            }
            
            genIM.Emit(OpCodes.Call, classMethod);
            if (returnType == typeof(void))
            {
                genIM.Emit(OpCodes.Pop);
            }
            genIM.Emit(OpCodes.Ret);


            tb.DefineMethodOverride(mbIM, interfaceMethod);

            Type t = tb.CreateType();

            return (t, null);
        }

    }
    public static class GeneralizedMethodBuilder
    {
        public static TMethod GetMultiMethod<TMethod>()
            where TMethod : class, IMultiMethod
        {
            var t = ILMethodGenerator.Generate<TMethod>();
            var a = Activator.CreateInstance(t.Dispatcher) as TMethod;
            return a;
        }
        public static TMethod GetPolymorphicMethod<TMethod>()
           where TMethod : class, IPolymorphicMethod
        {
            var t = ILMethodGenerator.Generate<TMethod>();
            var a = Activator.CreateInstance(t.Dispatcher) as TMethod;
            return a;
        }
    }
}

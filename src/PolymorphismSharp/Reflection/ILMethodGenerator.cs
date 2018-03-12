using PolymorphismSharp.Management;
using PolymorphismSharp.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace PolymorphismSharp.Reflection
{
    /*
     class MethodCustomProxy : MethodCustom
     {
        private IGeneralizedMethodDispatcher _dispatcher;
        public MethodCustomProxy(IGeneralizedMethodDispatcher management)
        {
            _dispatcher = dispatcher;
        }
        public override TResult Call(TArg1 arg1, ...)
        {
            return _dispatcher.Call(new object[] {arg1, ...});
        }
     }
    */
    static class ILMethodGenerator
    {
        private static AssemblyName _aName = new AssemblyName("DynamicAssemblyPolymorphismSharp");
        private static AssemblyBuilder _ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(Guid.NewGuid().ToString()), AssemblyBuilderAccess.Run);
        private static ModuleBuilder _mb = _ab.DefineDynamicModule(_aName.Name);
        public static Assembly Assembly { get; } = _ab;


        public static Type Generate(Type contractType)
        {
            var contractMethod = contractType.GetMethod("Call");
            var contractMethodArgs = contractMethod.GetParameters().Select(x => x.ParameterType).ToArray();
            var returnType = contractMethod.ReturnType;
            var managemetType = typeof(IGeneralizedMethodDispatcher);
            var baseType = contractType;
            var ccc = baseType.GetConstructors();
            var baseConstructor = baseType.GetConstructor(Type.EmptyTypes);
            if (baseConstructor == null) baseConstructor = typeof(object).GetConstructor(Type.EmptyTypes);

            var classType = typeof(IGeneralizedMethodDispatcher);
            var classMethod = classType.GetMethod("Call");
            var constructorArgs = new Type[] { classType };

            var interfaceName = contractType.Name.Split("`")[0];
            if (interfaceName[0] == 'I') interfaceName = interfaceName.Substring(1);
            TypeBuilder tb = _mb.DefineType(interfaceName + "Proxy " + Guid.NewGuid().ToString(), TypeAttributes.Public, baseType);

            FieldBuilder fbManagement = tb.DefineField(
                   "_management",
                   managemetType,
                   FieldAttributes.Private);

            ConstructorBuilder ctor = tb.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, constructorArgs);
            ILGenerator ctorIL = ctor.GetILGenerator();
            ctorIL.Emit(OpCodes.Ldarg_0);
            ctorIL.Emit(OpCodes.Call, baseConstructor);
            ctorIL.Emit(OpCodes.Ldarg_0);
            ctorIL.Emit(OpCodes.Ldarg_1);
            ctorIL.Emit(OpCodes.Stfld, fbManagement);
            ctorIL.Emit(OpCodes.Ret);

            MethodBuilder mbIM = tb.DefineMethod(contractType.Name + "." + contractMethod.Name,
                MethodAttributes.Private | MethodAttributes.HideBySig |
                MethodAttributes.NewSlot | MethodAttributes.Virtual |
                MethodAttributes.Final,
                returnType,
                contractMethodArgs);
            ILGenerator genIM = mbIM.GetILGenerator();
            genIM.Emit(OpCodes.Ldarg, 0);
            genIM.Emit(OpCodes.Ldfld, fbManagement);
            genIM.Emit(OpCodes.Ldc_I4, contractMethodArgs.Length);
            genIM.Emit(OpCodes.Newarr, typeof(object));

            for (int i = 0; i < contractMethodArgs.Length; i++)
            {
                genIM.Emit(OpCodes.Dup);
                genIM.Emit(OpCodes.Ldc_I4, i);
                genIM.Emit(OpCodes.Ldarg, i + 1);
                if (contractMethodArgs[i].IsValueType)
                {
                    genIM.Emit(OpCodes.Box, contractMethodArgs[i]);
                }
                genIM.Emit(OpCodes.Stelem_Ref);
            }

            genIM.Emit(OpCodes.Callvirt, classMethod);
            if (returnType == typeof(void))
            {
                genIM.Emit(OpCodes.Pop);
            }
            else if (returnType.IsValueType)
            {
                genIM.Emit(OpCodes.Unbox_Any, returnType);
            }
            genIM.Emit(OpCodes.Ret);


            tb.DefineMethodOverride(mbIM, contractMethod);

            Type t = tb.CreateType();

            return t;
        }
        /*
          How make Property
            //tb.AddInterfaceImplementation(interfaceType);

            
            if (interfaceType.GetInterface("IMultiMethod") == null)
            {
                FieldBuilder fbNextMethod = tb.DefineField(
                    "m_NextMethod",
                    interfaceType,
                    FieldAttributes.Private);

                PropertyBuilder pbNextMethod = tb.DefineProperty(
                    "NextMethod",
                    PropertyAttributes.HasDefault,
                    interfaceType,
                    null);

                // The property "set" and property "get" methods require a special
                // set of attributes.
                MethodAttributes getSetAttr = MethodAttributes.Virtual | MethodAttributes.Public;

                // Define the "get" accessor method for Number. The method returns
                // an integer and has no arguments. (Note that null could be 
                // used instead of Types.EmptyTypes)
                MethodBuilder mbNextMethodGetAccessor = tb.DefineMethod(
                    "get_NextMethod",
                    getSetAttr,
                    interfaceType,
                    Type.EmptyTypes);

                ILGenerator NextMethodGetIL = mbNextMethodGetAccessor.GetILGenerator();
                // For an instance property, argument zero is the instance. Load the 
                // instance, then load the private field and return, leaving the
                // field value on the stack.
                NextMethodGetIL.Emit(OpCodes.Ldarg_0);
                NextMethodGetIL.Emit(OpCodes.Ldfld, fbNextMethod);
                NextMethodGetIL.Emit(OpCodes.Ret);

                // Define the "set" accessor method for Number, which has no return
                // type and takes one argument of type int (Int32).
                MethodBuilder mbNextMethodSetAccessor = tb.DefineMethod(
                    "set_NextMethod",
                    getSetAttr,
                    null,
                    new Type[] { interfaceType });

                ILGenerator numberSetIL = mbNextMethodSetAccessor.GetILGenerator();
                // Load the instance and then the numeric argument, then store the
                // argument in the field.
                numberSetIL.Emit(OpCodes.Ldarg_0);
                numberSetIL.Emit(OpCodes.Ldarg_1);
                numberSetIL.Emit(OpCodes.Stfld, fbNextMethod);
                numberSetIL.Emit(OpCodes.Ret);

                // Last, map the "get" and "set" accessor methods to the 
                // PropertyBuilder. The property is now complete. 
                pbNextMethod.SetGetMethod(mbNextMethodGetAccessor);
                pbNextMethod.SetSetMethod(mbNextMethodSetAccessor);

                //tb.DefineMethodOverride(mbNextMethodGetAccessor, interfaceMethod);
                //tb.DefineMethodOverride(mbNextMethodSetAccessor, interfaceMethod);

            }
            
        */
    }

}

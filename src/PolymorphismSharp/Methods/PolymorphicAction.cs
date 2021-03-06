﻿using PolymorphismSharp.Management;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PolymorphismSharp.Methods
{
    public abstract class PolymorphicAction<TArg> : PolymorphicMethod
    {
        public virtual bool Pre(TArg arg) => true;
        public virtual bool Post(TArg arg) => true;
        public abstract void Call(TArg arg);
    }
    public abstract class PolymorphicAction<TArg1, TArg2> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15);
    }
    public abstract class PolymorphicAction<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> : PolymorphicMethod
    {
        public virtual bool Pre(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16) => true;
        public virtual bool Post(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16) => true;
        public abstract void Call(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16);
    }
}

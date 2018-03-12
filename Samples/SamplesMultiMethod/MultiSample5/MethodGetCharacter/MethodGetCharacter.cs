using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;

namespace Sample.MethodGetCharacter
{
    public abstract class MethodGetCharacter : MultiFunc<string, int, char>
    {
    }

    static class MethodGetCharacterExtensions
    {
        private static MethodGetCharacter _contract;
        static MethodGetCharacterExtensions()
        {
            _contract = GeneralizedMethodBuilder.GetContract<MethodGetCharacter>();
        }
        public static char GetCharacter(this string arg1, int arg2)
        {
            return _contract.Call(arg1, arg2);
        }
    }
}

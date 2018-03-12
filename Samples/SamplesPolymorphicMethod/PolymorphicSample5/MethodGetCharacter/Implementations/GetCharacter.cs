using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;

namespace Sample.MethodGetCharacter.Implementations
{
    class GetCharacterDerive : Derive
        <(
        GetCharacterEmptyString,
        GetCharacterNegativeIndex,
        GetCharacterOverflowIndex,
        GetCharacterOk
        )>{}

    class GetCharacterEmptyString : MethodGetCharacter
    {
        public override bool Pre(string arg1, int arg2)
        {
            return string.IsNullOrEmpty(arg1);
        }
        public override bool Post(string arg1, int arg2, char result)
        {
            return result == '-';
        }
        public override char Call(string arg1, int arg2)
        {
            Console.WriteLine("Method " + this.GetType().Name);
            return '-';
        }
    }
    class GetCharacterNegativeIndex : MethodGetCharacter
    {
        public override bool Pre(string arg1, int arg2)
        {
            return arg2 < 0;
        }
        public override bool Post(string arg1, int arg2, char result)
        {
            return result == '-';
        }
        public override char Call(string arg1, int arg2)
        {
            Console.WriteLine("Method " + this.GetType().Name);
            return '-';
        }
    }
    class GetCharacterOverflowIndex : MethodGetCharacter
    {
        public override bool Pre(string arg1, int arg2)
        {
            return arg1.Length <= arg2;
        }
        public override bool Post(string arg1, int arg2, char result)
        {
            return result == '-';
        }
        public override char Call(string arg1, int arg2)
        {
            Console.WriteLine("Method " + this.GetType().Name);
            return '-';
        }
    }
    class GetCharacterOk : MethodGetCharacter
    {
        public override char Call(string arg1, int arg2)
        {
            Console.WriteLine("Method " + this.GetType().Name);
            return arg1[arg2];
        }
    }

    
}

using Sample.Models;
using System;
using Sample.MethodDo;
using System.Collections.Generic;

namespace Sample
{
    interface IDerived<T> { }
    public interface IPre
    {
        bool Call(string email, string password, string name);
    }

    public class PreAttribute : Attribute
    {
        public PreAttribute(IPre val)
        {
        }
    }

    static class ExtensionAccount
    {
        public static void SignUp(this Account acc)
        {
            
        }
    }
    class Account
    {
        public string Email;
        public string Password;
        public string Name;
    }
    
    //[Pre(labda)]
    class SignUpUncorrectEmail
    {
        public void Call(string email, string password, string name)
        {

        }
    }
    
    class SignUpUncorrectPassword
    {
        public void Call(string email, string password, string name)
        {

        }
    }
    static class SignUpDerivedd
    {
        public static List<Type> arr;
        static SignUpDerivedd()
        {
            arr = new List<Type>
            {
                typeof(SignUpUncorrectEmail),
                typeof(SignUpUncorrectPassword)
            };
        }
    }
    
    class SignUpDerived : IDerived<(
        SignUpUncorrectEmail,
        SignUpUncorrectPassword

        )>{}

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<A>
            {
                new BC(),
                new CB()
            };
            foreach (var it in arr)
            {
                Console.WriteLine(it.GetType().Name + ":");
                it.Do(args);
                Console.WriteLine();
                
            }
        }
    }
}
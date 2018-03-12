using System;
using Sample.MethodGetCharacter;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Arg1, int Arg2)[] arr = new(string Arg1, int Arg2)[]
            {
                ("", 0),
                ("first", -1),
                ("second", 10),
                ("third", 1)
            };
            foreach (var it in arr)
            {
                Console.WriteLine(it.Arg1 + " " + it.Arg2 + ":");
                var ch = it.Arg1.GetCharacter(it.Arg2);
                Console.WriteLine(ch);
                Console.WriteLine();
            }
        }
    }
}

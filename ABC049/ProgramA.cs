using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var result = s == "a" || s == "i" || s == "u" || s == "e" || s == "o";
            Console.WriteLine(result ? "vowel" : "consonant");
        }
    }
}

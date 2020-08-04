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
            var result = s[0] == s[1] || s[1] == s[2] || s[2] == s[3];
            Console.WriteLine(result ? "Bad" : "Good");
        }
    }
}

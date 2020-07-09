using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var first = s[0];
            var last = s[s.Length - 1];
            var isSame = first == last;
            var isOdd = s.Length % 2 == 0;

            Console.WriteLine(isSame ^ isOdd ? "Second" : "First");
        }

    }
}

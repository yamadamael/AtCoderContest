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
            var result = true;
            result = result && s.Contains("a");
            result = result && s.Contains("b");
            result = result && s.Contains("c");
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}

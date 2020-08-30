using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var d = int.Parse(inputs[0]);
            var t = int.Parse(inputs[1]);
            var s = int.Parse(inputs[2]);
            var result = (d / (float)s) <= t;
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}

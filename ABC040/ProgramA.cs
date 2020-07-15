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
            var n = long.Parse(inputs[0]);
            var x = long.Parse(inputs[1]);
            var result = Math.Min(x - 1, n - x);
            Console.WriteLine(result);
        }
    }
}

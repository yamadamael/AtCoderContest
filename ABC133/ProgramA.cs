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
            var a = long.Parse(inputs[1]);
            var b = long.Parse(inputs[2]);
            var result = Math.Min(a * n, b);
            Console.WriteLine(result);
        }
    }
}

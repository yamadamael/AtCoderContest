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
            var m = long.Parse(inputs[1]);
            var k = long.Parse(inputs[2]);

            var r1 = n + m;
            var r2 = n + k;
            var r3 = k + m;

            var result = Math.Min(r1, r2);
            result = Math.Min(r3, result);
            Console.WriteLine(result);
        }
    }
}

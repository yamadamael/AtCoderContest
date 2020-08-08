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
            var a = long.Parse(inputs[0]);
            var b = long.Parse(inputs[1]);

            var r1 = a + b;
            var r2 = a - b;
            var r3 = a * b;
            var result = new long[] { r1, r2, r3 };

            Console.WriteLine(result.Max());
        }
    }
}

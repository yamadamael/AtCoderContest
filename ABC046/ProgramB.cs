using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var k = long.Parse(inputs[1]);

            var result = k * Math.Pow(k - 1, n - 1);
            Console.WriteLine(result);
        }
    }
}

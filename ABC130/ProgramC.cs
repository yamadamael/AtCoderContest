using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var w = long.Parse(inputs[0]);
            var h = long.Parse(inputs[1]);
            var x = long.Parse(inputs[2]);
            var y = long.Parse(inputs[3]);

            var result1 = w * h / 2d;
            var result2 = 2 * x == w && 2 * y == h ? 1 : 0;

            Console.WriteLine(string.Format("{0} {1}", result1, result2));
        }
    }
}

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
            var s = long.Parse(inputs[1]);
            var t = long.Parse(inputs[2]);

            var w = long.Parse(Console.ReadLine());

            var result = s <= w && w <= t ? 1 : 0;
            for (var i = 0; i < n - 1; i++)
            {
                w += long.Parse(Console.ReadLine());
                result += s <= w && w <= t ? 1 : 0;
            }

            Console.WriteLine(result);
        }
    }
}

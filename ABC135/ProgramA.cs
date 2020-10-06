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
            inputs = inputs.OrderBy(x => true).ToArray();
            var n = long.Parse(inputs[0]);
            var m = long.Parse(inputs[1]);
            var k = (m - n) / 2 + n;

            if (Math.Abs(n - k) != Math.Abs(m - k))
            {
                Console.WriteLine("IMPOSSIBLE");
                return;
            }

            Console.WriteLine(k);
        }
    }
}

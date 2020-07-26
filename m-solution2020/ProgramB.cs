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
            var a = long.Parse(inputs[0]);
            var b = long.Parse(inputs[1]);
            var c = long.Parse(inputs[2]);

            var k = long.Parse(Console.ReadLine());

            var result = 0;

            while (a >= b)
            {
                b *= 2;
                result++;
            }

            while (b >= c)
            {
                c *= 2;
                result++;
            }

            Console.WriteLine(result <= k ? "Yes" : "No");
        }
    }
}

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
            var d = long.Parse(inputs[1]);
            var result = 0;

            for (var i = 0; i < n; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var x = long.Parse(inputs1[0]);
                var y = long.Parse(inputs1[1]);

                var dist = Math.Sqrt(x * x + y * y);
                if (dist <= d) result++;

            }
            Console.WriteLine(result);
        }
    }
}

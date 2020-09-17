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
            var m = long.Parse(inputs[1]);
            var x = long.Parse(inputs[2]);

            var a = 0;
            var b = 0;

            var inputs1 = Console.ReadLine().Split(" ");
            for (var i = 0; i < m; i++)
            {
                var r = int.Parse(inputs1[i]);
                if (r < x)
                    a++;
                else
                    b++;
            }

            var result = Math.Min(a, b);
            Console.WriteLine(result);
        }
    }
}

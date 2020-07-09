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
            var x = long.Parse(inputs[2]);

            // var y = (a / x) + ((a % x) != 0 ? 1 : 0);
            // var count = 0L;

            // while (y * x <= b)
            // {
            //     if ((y * x) <= b)
            //     {
            //         count++;
            //         y++;
            //     }
            // }

            var count = (b / x) - ((a - 1) / x);
            if (a == 0 && x > 1)
                count++;

            Console.WriteLine(count);
        }
    }
}

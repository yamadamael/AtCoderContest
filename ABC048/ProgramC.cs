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
            var n = long.Parse(inputs[0]);
            var x = long.Parse(inputs[1]);

            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            var result = 0L;

            if (list[0] > x)
            {
                result += list[0] - x;
                list[0] = x;
            }

            for (var i = 1; i < n; i++)
            {
                if (list[i - 1] + list[i] <= x)
                {
                    continue;
                }
                else
                {
                    result += list[i] - (x - list[i - 1]);
                    list[i] = x - list[i - 1];
                }
            }


            Console.WriteLine(result);
        }
    }
}

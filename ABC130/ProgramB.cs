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
            var x = long.Parse(inputs[1]);

            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            var result = 1;
            var d = new int[n + 1];
            for (var i = 1; i < n + 1; i++)
            {
                d[i] = d[i - 1] + list[i - 1];
                if (d[i] > x)
                {
                    break;
                }
                result++;
            }

            Console.WriteLine(result);
        }
    }
}

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
            var list = new int[n][];

            for (var i = 0; i < n; i++)
            {
                list[i] = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            }

            var result = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    var dist = 0d;
                    for (var k = 0; k < d; k++)
                    {
                        var l = (list[i][k] - list[j][k]);
                        dist += l * l;
                    }
                    dist = Math.Sqrt(dist);
                    if (dist < (int)(dist) + 1e-10) result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}

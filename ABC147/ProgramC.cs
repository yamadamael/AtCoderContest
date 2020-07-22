using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var graph = new List<(int, int)>[n];

            for (var i = 0; i < n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                graph[i] = new List<(int, int)>();
                for (var j = 0; j < a; j++)
                {
                    var inputs = Console.ReadLine().Split(" ");
                    var x = int.Parse(inputs[0]) - 1;
                    var y = int.Parse(inputs[1]);
                    graph[i].Add((x, y));
                }
            }

            var result = 0;

            for (var bits = 0; bits < 1 << n; bits++)
            {
                var ok = true;
                var count = 0;
                for (var i = 0; i < n; i++)
                {
                    if (((bits >> i) & 1) == 0) continue;
                    count++;
                    for (var j = 0; j < graph[i].Count; j++)
                    {
                        if ((bits >> (graph[i][j].Item1) & 1) != graph[i][j].Item2)
                        {
                            ok = false;
                        }
                    }
                }
                if (ok)
                {
                    result = Math.Max(result, count);
                }
            }

            Console.WriteLine(result);
        }
    }
}

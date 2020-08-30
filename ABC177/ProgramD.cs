using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static List<int>[] _graph;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            _graph = new List<int>[n];
            for (var i = 0; i < n; i++)
            {
                _graph[i] = new List<int>();
            }

            for (var i = 0; i < m; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var a = int.Parse(inputs1[0]) - 1;
                var b = int.Parse(inputs1[1]) - 1;

                if (!_graph[a].Contains(b))
                {
                    foreach (var f in _graph[a])
                    {
                        if (!_graph[f].Contains(b))
                        {
                            _graph[f].Add(b);
                            _graph[b].Add(f);
                        }
                    }

                    _graph[a].Add(b);
                    _graph[b].Add(a);
                }
            }

            // for (var i = 0; i < n; i++)
            // {
            //     foreach (var g1 in _graph[i])
            //     {
            //         foreach (var g2 in _graph[i])
            //         {
            //             if (g1 != g2 && !_graph[g1].Contains(g2))
            //             {
            //                 _graph[g1].Add(g2);
            //                 _graph[g2].Add(g1);
            //             }
            //         }
            //     }
            // }

            var max = 0;
            var maxCount = 0;
            foreach (var g in _graph)
            {
                var c = g.Count;
                if (max < c)
                {
                    max = c;
                    maxCount = 1;
                }
                else if (max == c)
                {
                    maxCount++;
                }
            }

            var result = 0;
            if (n == max + 1 && maxCount == n)
            {
                result = n;
            }
            else
            {
                result = max + 1;
            }

            Console.WriteLine(result);
        }
    }
}

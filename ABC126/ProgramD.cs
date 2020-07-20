using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static List<(int, int)>[] _graph;
        static int[] _res;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            _graph = new List<(int, int)>[n];
            _res = new int[n];
            for (var i = 0; i < n; i++)
            {
                _graph[i] = new List<(int, int)>();
            }

            for (var i = 0; i < n - 1; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                var u = int.Parse(inputs[0]) - 1;
                var v = int.Parse(inputs[1]) - 1;
                var w = int.Parse(inputs[2]);
                _graph[u].Add((v, w));
                _graph[v].Add((u, w));
            }

            dfs(0, -1, 0);

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(_res[i]);
            }
        }

        static void dfs(int v, int p, int c)
        {
            // Console.WriteLine(string.Format("{0},{1}", v, c));
            _res[v] = c;

            foreach (var e in _graph[v])
            {
                if (e.Item1 == p) continue;
                if ((e.Item2 & 1) == 1)
                    dfs(e.Item1, v, 1 - c);
                else
                    dfs(e.Item1, v, c);
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static int[] _graph;
        static bool[] _seen;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            _graph = new int[n];
            _seen = new bool[n];
            for (var i = 0; i < n; i++)
            {
                _graph[i] = int.Parse(Console.ReadLine()) - 1;
            }

            // var result = 0;
            // var current = 0;
            // for (var i = 0; i < n; i++)
            // {
            //     seen[i] = true;
            //     current = list[current];
            //     result++;
            //     if (current == 1)
            //     {
            //         break;
            //     }
            //     if (seen[current])
            //     {
            //         result = -1;
            //         break;
            //     }
            // }



            Console.WriteLine(dfs(0, 0));
        }

        static int dfs(int n, int count)
        {
            if (n == 1) return count;
            _seen[n] = true;

            var next = _graph[n];
            if (_seen[next]) return -1;
            return dfs(next, ++count);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static List<int>[] _list;
        static int _n;
        static int _m;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            _n = int.Parse(inputs[0]);
            _m = int.Parse(inputs[1]);

            _list = new List<int>[_n];
            for (var i = 0; i < _n; i++)
            {
                _list[i] = new List<int>();
            }

            for (var i = 0; i < _m; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var a = int.Parse(inputs1[0]) - 1;
                var b = int.Parse(inputs1[1]) - 1;
                _list[a].Add(b);
            }

            var result = dfs(0, 0) ? "POSSIBLE" : "IMPOSSIBLE";
            Console.WriteLine(result);
        }

        static bool dfs(int v, int count)
        {
            // Console.WriteLine(string.Join(", ", v, count));

            if (count == 2)
            {
                return v == _n - 1;
            }

            foreach (var l in _list[v])
            {
                var b = dfs(l, count + 1);
                if (b)
                    return true;
            }

            return false;
        }
    }
}

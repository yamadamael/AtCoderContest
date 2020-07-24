// https://drken1215.hatenablog.com/entry/2020/05/04/190252

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        struct Info
        {
            public int a;
            public int b;
            public int c;
            public int d;
        }

        static int _depth, _count;
        static Info[] _list;

        // 深さ優先探索
        static int dfs(List<int> g)
        {
            if (g.Count == _depth)
            {
                // Console.WriteLine(string.Join("", g));
                return calc(g);
            }

            var start = g.Count > 0 ? g.Last() : 1;
            var result = 0;
            for (var i = start; i <= _count; i++)
            {
                g.Add(i);
                result = Math.Max(result, dfs(g));
                g.RemoveAt(g.Count - 1);
            }

            return result;
        }

        static int calc(List<int> g)
        {
            var result = 0;
            foreach (var l in _list)
            {
                if (g[l.b] - g[l.a] == l.c)
                {
                    result += l.d;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);
            var q = int.Parse(inputs[2]);

            _depth = n;
            _count = m;

            _list = new Info[q];
            for (var i = 0; i < q; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                _list[i].a = int.Parse(inputs1[0]) - 1;
                _list[i].b = int.Parse(inputs1[1]) - 1;
                _list[i].c = int.Parse(inputs1[2]);
                _list[i].d = int.Parse(inputs1[3]);
            }

            var result = dfs(new List<int>());
            Console.WriteLine(result);
        }
    }
}

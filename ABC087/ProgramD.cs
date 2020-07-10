// https://bplain.hatenablog.com/entry/2018/06/20/174128

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        struct Info
        {
            public int to;
            public int dist;
        }

        // グラフ
        static List<Info>[] _graph;
        // 通過済みか
        static bool[] _seen;
        // 0起点の距離
        static int[] _d;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            _graph = new List<Info>[n];
            for (var i = 0; i < n; i++)
            {
                _graph[i] = new List<Info>();
            }

            for (var i = 0; i < m; i++)
            {
                var inputsM = Console.ReadLine().Split(" ");
                var l = int.Parse(inputsM[0]) - 1;
                var r = int.Parse(inputsM[1]) - 1;
                var d = int.Parse(inputsM[2]);

                // 辺追加(有効グラフ)
                _graph[l].Add(new Info()
                {
                    to = r,
                    dist = d,
                });
                _graph[r].Add(new Info()
                {
                    to = l,
                    dist = -d,
                });
            }

            _seen = new bool[n];
            _d = new int[n];
            for (var i = 0; i < n; i++)
            {
                // 探索
                if (_seen[i]) continue;
                if (dfs(i, 0))
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }

        // dfs 自作版
        // trueが返ったら矛盾
        static bool dfs(int b, int e, int d, int sum)
        {
            _seen[b] = true;
            foreach (var i in _graph[b])
            {
                var next = i.to;
                if (_seen[next]) continue;

                var nSum = sum + i.dist;
                // 矛盾チェック
                if (next == e && d != nSum) return true;

                if (dfs(next, e, d, nSum))
                {
                    return true;
                }
            }
            return false;
        }

        // dfs
        // trueが返ったら矛盾
        static bool dfs(int v, int dist)
        {
            // 通過済みチェック
            if (_seen[v])
            {
                // 保存してある距離と異なる場合矛盾(true)を返す
                return _d[v] != dist;
            }

            _seen[v] = true;
            _d[v] = dist;
            foreach (var i in _graph[v])
            {
                if (dfs(i.to, _d[v] + i.dist))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

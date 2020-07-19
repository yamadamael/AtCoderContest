using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var k = int.Parse(inputs[1]);
            var l = int.Parse(inputs[2]);

            var ufr = new UnionFind(n);
            var uft = new UnionFind(n);

            for (var i = 0; i < k; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var p = int.Parse(inputs1[0]) - 1;
                var q = int.Parse(inputs1[1]) - 1;
                ufr.unite(p, q);
            }

            for (var i = 0; i < l; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var r = int.Parse(inputs1[0]) - 1;
                var s = int.Parse(inputs1[1]) - 1;
                uft.unite(r, s);
            }

            var list = new Dictionary<(int, int), int>();
            for (var i = 0; i < n; i++)
            {
                var r1 = ufr.root(i);
                var r2 = uft.root(i);
                var x = (r1, r2);
                // Console.WriteLine(x);
                if (list.ContainsKey(x))
                    list[x]++;
                else
                    list.Add(x, 1);
            }

            var result = new int[n];
            for (var i = 0; i < n; i++)
            {
                var r1 = ufr.root(i);
                var r2 = uft.root(i);
                var x = (r1, r2);
                result[i] = list[x];
            }

            Console.WriteLine(string.Join(" ", result));
        }

        public class UnionFind
        {
            int[] par, rank;

            // 初期化
            // par[i]=iの場合、根である
            public UnionFind(int n)
            {
                par = new int[n];
                rank = new int[n];
                for (var i = 0; i < n; i++)
                {
                    par[i] = i;
                    rank[i] = 0;
                }
            }

            // 木の根を求める
            public int root(int x)
            {
                if (par[x] == x)
                {
                    return x;
                }
                else
                {
                    par[x] = root(par[x]);
                    return par[x];
                }
            }

            // 2頂点が同じ集合か
            public bool same(int x, int y)
            {
                return root(x) == root(y);
            }

            // 集合の併合(ランク考慮あり)
            public void unite(int x, int y)
            {
                var nx = root(x);
                var ny = root(y);
                if (nx == ny) return;
                if (rank[nx] < rank[ny])
                {
                    par[nx] = ny;
                }
                else
                {
                    par[ny] = nx;
                    if (rank[nx] == rank[ny])
                        rank[nx]++;
                }
            }
        }
    }
}

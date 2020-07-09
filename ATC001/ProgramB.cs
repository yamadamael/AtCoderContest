using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static int[] par, rank;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var q = int.Parse(inputs[1]);

            init(n);
            for (var i = 0; i < q; i++)
            {
                var inputsQ = Console.ReadLine().Split(" ");
                var p = int.Parse(inputsQ[0]);
                var a = int.Parse(inputsQ[1]);
                var b = int.Parse(inputsQ[2]);

                if (p == 0)
                {
                    // 連結
                    unite(a, b);
                }
                else
                {
                    // 判定
                    Console.WriteLine(same(a, b) ? "Yes" : "No");
                }
            }
        }

        // 初期化
        // par[i]=iの場合、根である
        static void init(int n)
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
        static int root(int x)
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
        static bool same(int x, int y)
        {
            return root(x) == root(y);
        }

        // 集合の併合(ランク考慮あり)
        static void unite(int x, int y)
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

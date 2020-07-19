using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        struct Info
        {
            public int a;
            public int b;
        }

        static void Main(string[] args)
        {
            var W = int.Parse(Console.ReadLine());

            var inputs = Console.ReadLine().Split(" ");
            var N = int.Parse(inputs[0]);
            var K = int.Parse(inputs[1]);

            var list = new Info[N];
            for (var i = 0; i < N; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var a = int.Parse(inputs1[0]);
                var b = int.Parse(inputs1[1]);
                list[i] = new Info() { a = a, b = b };
            }

            // dp初期化
            var sumV = list.Sum(x => x.b);
            var dp = new int[N + 1, K + 1, W + 1];

            // dp
            // http://chiwawa-star.hatenablog.com/entry/2018/03/04/190244

            for (var i = 0; i < N; i++) // list要素数
            {
                for (var j = 0; j < K; j++) // 使用制限
                {
                    for (var k = 0; k < W + 1; k++) // 幅(価値)
                    {
                        if (k >= list[i].a)
                        {
                            dp[i + 1, j + 1, k] = Math.Max(dp[i, j + 1, k], dp[i, j, k]);
                            dp[i + 1, j + 1, k] = Math.Max(dp[i + 1, j + 1, k], dp[i, j, k - list[i].a] + list[i].b);
                        }
                        else
                        {
                            dp[i + 1, j + 1, k] = Math.Max(dp[i, j + 1, k], dp[i, j, k]);
                        }
                    }
                }
            }

            // log
            for (var k = 0; k < W + 1; k++)
            {
                Console.WriteLine(string.Format("k: {0}", k));
                for (var i = 0; i < N + 1; i++)
                {
                    var s = "";
                    for (var j = 0; j < K + 1; j++)
                    {
                        s += string.Format("{0:D3}, ", dp[i, j, k]);
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }

            Console.WriteLine(dp[N, K, W]);
        }
    }
}

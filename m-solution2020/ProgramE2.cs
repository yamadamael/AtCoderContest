// 解説のサンプル写経
// https://atcoder.jp/contests/m-solutions2020/submissions/15122924

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramE2
    {

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new (int, int, int)[n];
            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                var x = int.Parse(inputs[0]);
                var y = int.Parse(inputs[1]);
                var p = int.Parse(inputs[2]);
                list[i] = (x, y, p);
            }

            var result = solve(n, list);

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }

        static long[] solve(int n, (int, int, int)[] list)
        {
            var xsel = new int[1 << n, n];
            var ysel = new int[1 << n, n];

            for (var i = 0; i < (1 << n); i++)
            {
                for (var j = 0; j < n; j++)
                {
                    xsel[i, j] = Math.Abs(list[j].Item1);
                    ysel[i, j] = Math.Abs(list[j].Item2);
                    for (var k = 0; k < n; k++)
                    {
                        if (((i >> k) & 1) == 1)
                        {
                            xsel[i, j] = Math.Min(xsel[i, j], Math.Abs(list[j].Item1 - list[k].Item1));
                            ysel[i, j] = Math.Min(ysel[i, j], Math.Abs(list[j].Item2 - list[k].Item2));
                        }
                    }
                }
            }

            var result = Enumerable.Repeat(long.MaxValue, n + 1).ToArray();
            for (var i = 0; i < (1 << n); i++)
            {
                var cnt = 0;
                for (var j = 0; j < n; j++)
                {
                    if (((i >> j) & 1) == 1) cnt++;
                }

                for (var j = i; j >= 0; j--)
                {
                    j &= i;
                    var cost = 0L;
                    for (var k = 0; k < n; k++)
                    {
                        if (((i >> k) & 1) == 0)
                        {
                            cost += 1L * Math.Min(xsel[j, k], ysel[j, k]) * list[k].Item3;
                        }
                    }
                    result[cnt] = Math.Min(result[cnt], cost);
                }
            }

            return result;
        }
    }
}

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
            var n = long.Parse(inputs[0]);
            var w = long.Parse(inputs[1]);

            var list = new long[n, 2];
            for (var i = 0; i < n; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                list[i, 0] = long.Parse(inputs1[0]);
                list[i, 1] = long.Parse(inputs1[1]);
            }

            var dp = new long[n + 1, w + 1];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < w + 1; j++)
                {
                    if (j >= list[i, 0])
                    {
                        dp[i + 1, j] = Math.Max(dp[i, j - list[i, 0]] + list[i, 1], dp[i, j]);
                    }
                    else
                    {
                        dp[i + 1, j] = dp[i, j];
                    }
                }
            }

            // for (var i = 0; i < n + 1; i++)
            // {
            //     var s = "";
            //     for (var j = 0; j < w + 1; j++)
            //     {
            //         s += string.Format("{0:D3}, ", dp[i, j]);
            //     }
            //     Console.WriteLine(s);
            // }

            Console.WriteLine(dp[n, w]);
        }

    }
}

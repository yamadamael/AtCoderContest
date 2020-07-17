using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramE
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var w = long.Parse(inputs[1]);

            var maxV = 0L;
            var list = new long[n, 2];
            for (var i = 0; i < n; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                list[i, 0] = long.Parse(inputs1[0]);
                list[i, 1] = long.Parse(inputs1[1]);
                maxV += list[i, 1];
            }

            var dp = new long[n + 1, maxV + 1];
            for (var i = 0; i < n + 1; i++)
            {
                for (var j = 0; j < maxV + 1; j++)
                {
                    dp[i, j] = (int)1e9 + 7;
                }
            }
            dp[0, 0] = 0;

            for (var i = 0; i < n; i++)
            {
                for (var sumV = 0; sumV < maxV + 1; sumV++)
                {
                    if (sumV >= list[i, 1])
                    {
                        dp[i + 1, sumV] = Math.Min(dp[i, sumV - list[i, 1]] + list[i, 0], dp[i, sumV]);
                    }
                    else
                    {
                        dp[i + 1, sumV] = dp[i, sumV];
                    }
                }
            }

            // for (var i = -1; i < n + 1; i++)
            // {
            //     var s = "";
            //     for (var j = 0; j < maxV + 1; j++)
            //     {
            //         if (i < 0)
            //             s += string.Format("{0:D3}, ", j);
            //         else
            //             s += string.Format("{0:D3}, ", dp[i, j] == 1e9 + 7 ? 999 : dp[i, j]);
            //     }
            //     Console.WriteLine(s);
            // }

            var result = 0L;
            for (var i = 0; i < maxV + 1; i++)
            {
                // Console.WriteLine(string.Format("i: {0:D2}, dp[n,i]: {1}", i, dp[n, i]));
                if (dp[n, i] <= w)
                {
                    result = i;
                    // Console.WriteLine(string.Format("  {0}", result));
                }
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var mod = (int)1e9 + 7;
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            var ok = new bool[n + 1];
            for (var i = 0; i < n + 1; i++)
            {
                ok[i] = true;
            }

            for (var i = 0; i < m; i++)
            {
                var a = int.Parse(Console.ReadLine());
                ok[a] = false;
            }

            var dp = new int[n + 1];
            dp[0] = 1;
            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j <= Math.Min(n, i + 2); j++)
                {
                    // Console.WriteLine("i: " + i + ", j: " + j);
                    if (ok[j])
                    {
                        dp[j] += dp[i];
                        dp[j] %= mod;
                        // Console.WriteLine("  dp[" + j + "]: " + dp[j]);
                    }
                }
            }

            // for (var i = 0; i < n + 1; i++)
            // {
            //     Console.WriteLine(i + ": " + dp[i]);
            // }

            Console.WriteLine(dp[n]);
        }
    }
}

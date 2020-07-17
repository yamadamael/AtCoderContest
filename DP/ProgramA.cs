using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            var dp = new int[n];
            dp[0] = 0;
            dp[1] = Math.Abs(list[1] - list[0]);

            for (var i = 2; i < n; i++)
            {
                dp[i] = Math.Min(Math.Abs(list[i] - list[i - 2]) + dp[i - 2], Math.Abs(list[i] - list[i - 1]) + dp[i - 1]);
            }

            // for (var i = 0; i < n; i++)
            // {
            //     Console.WriteLine("dp[" + i + "]: " + dp[i]);
            // }
            Console.WriteLine(dp[n - 1]);
        }
    }
}

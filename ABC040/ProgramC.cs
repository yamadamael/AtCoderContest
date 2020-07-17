using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            var dp = new int[n];
            dp[0] = 0;
            dp[1] = Math.Abs(a[1] - a[0]);
            for (var i = 2; i < n; i++)
            {
                dp[i] = Math.Min(Math.Abs(a[i] - a[i - 2]) + dp[i - 2], Math.Abs(a[i] - a[i - 1]) + dp[i - 1]);
            }

            Console.WriteLine(dp[n - 1]);
        }
    }
}

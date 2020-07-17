using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var k = int.Parse(inputs[1]);

            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            var dp = new int[n];
            dp[0] = 0;
            dp[1] = Math.Abs(list[1] - list[0]);

            for (var i = 2; i < n; i++)
            {
                dp[i] = int.MaxValue;
                for (var next = i - 1; next >= Math.Max(i - k, 0); next--)
                {
                    dp[i] = Math.Min(dp[i], Math.Abs(list[i] - list[next]) + dp[next]);
                }
            }

            // for (var i = 0; i < n; i++)
            // {
            //     Console.WriteLine("dp[" + i + "]: " + dp[i]);
            // }
            Console.WriteLine(dp[n - 1]);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var list = new int[3, n];
            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                list[0, i] = int.Parse(inputs[0]);
                list[1, i] = int.Parse(inputs[1]);
                list[2, i] = int.Parse(inputs[2]);
            }

            var dp = new int[3, n];
            dp[0, 0] = list[0, 0];
            dp[1, 0] = list[1, 0];
            dp[2, 0] = list[2, 0];

            for (var i = 1; i < n; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var j1 = (j + 1) % 3;
                    var j2 = (j + 2) % 3;
                    dp[j, i] = list[j, i] + Math.Max(dp[j1, i - 1], dp[j2, i - 1]);
                }
            }

            var result = 0;
            for (var i = 0; i < 3; i++)
            {
                result = Math.Max(dp[i, n - 1], result);
            }

            Console.WriteLine(result);
        }
    }
}

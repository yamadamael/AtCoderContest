using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        // 解説を元にコード化
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            var result = long.MaxValue;

            var b = new List<int>();
            for (var i = 0; i < n; i++)
            {
                b.Add(a[i] - (i + 1));
            }

            b.Sort();

            if (n % 2 == 0)
            {
                var b1 = n / 2;
                var b2 = b1 + 1;
                for (var i = b1; i <= b2; i++)
                {
                    result = Math.Min(result, calc(a, b[i]));
                }
            }
            else
            {
                result = calc(a, b[n / 2]);
            }

            Console.WriteLine(result);
        }

        static long calc(List<int> list, int b)
        {
            var result = 0L;
            for (var i = 0; i < list.Count; i++)
            {
                result += Math.Abs(list[i] - (b + i + 1));
            }
            return result;
        }
    }
}

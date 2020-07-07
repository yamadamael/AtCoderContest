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
            var list = new List<long>();
            for (var i = 0; i < n; i++)
            {
                list.Add(long.Parse(Console.ReadLine()));
            }

            Console.WriteLine(lcm(list));
        }

        // 最大公約数
        // ユークリッドの互除法を利用
        static long gcd(long a, long b)
        {
            if (b > a)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            if (b == 0)
            {
                return a;
            }

            return gcd(b, a % b);
        }

        // 最大公約数
        static long gcd(List<long> list)
        {
            var result = list[0];

            for (var i = 1; i < list.Count; i++)
            {
                result = gcd(result, list[i]);
            }

            return result;
        }

        // 最小公倍数
        static long lcm(long a, long b)
        {
            return a / gcd(a, b) * b;
        }

        // 最小公倍数
        static long lcm(List<long> list)
        {
            var result = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                result = lcm(result, list[i]);
            }

            return result;
        }
    }
}

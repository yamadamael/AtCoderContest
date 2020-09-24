using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC2
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            var result = gcd(list);
            Console.WriteLine(result);
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
    }
}

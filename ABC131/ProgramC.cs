// 写経 https://drken1215.hatenablog.com/entry/2019/06/22/224100

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var a = long.Parse(inputs[0]);
            var b = long.Parse(inputs[1]);
            var c = long.Parse(inputs[2]);
            var d = long.Parse(inputs[3]);

            var result = calc(b, c, d) - calc(a - 1, c, d);
            Console.WriteLine(result);
        }

        static long calc(long n, long c, long d)
        {
            var result = n;
            var l = lcm(c, d);
            result -= (n / c + n / d - n / l);
            return result;
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

        // 最小公倍数
        static long lcm(long a, long b)
        {
            return a / gcd(a, b) * b;
        }
    }
}

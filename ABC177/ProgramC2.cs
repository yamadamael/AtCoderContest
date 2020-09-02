using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC2
    {
        static void Main(string[] args)
        {
            var mod = (long)1e9 + 7;
            var n = long.Parse(Console.ReadLine());

            var a = new long[n];
            var b = new long[n + 1];
            var inputs = Console.ReadLine().Split(" ");
            for (var i = 0; i < n; i++)
            {
                a[i] = long.Parse(inputs[i]);
                b[i + 1] = b[i] + a[i];
            }

            var result = 0L;

            for (var i = 0; i < n; i++)
            {
                var sum = (b[n] - b[i + 1]) % mod;
                result += a[i] * sum;
                result %= mod;
            }

            Console.WriteLine(result);
        }
    }
}

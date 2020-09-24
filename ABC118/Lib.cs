using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    public class Lib
    {
        // 約数リストを取得する
        // O(sqrt(N))
        static List<long> Divisor(long n)
        {
            var result = new List<long>();
            for (var i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                    if (i * i != n)
                        result.Add(n / i);
                }
            }
            return result;
        }

        // 総和
        // Ei
        static long SumI(long i)
        {
            return (i * (i + 1)) / 2;
        }

        // 繰り返しn乗法
        static long Pow(long n, long p, int mod = (int)1e9 + 7)
        {
            if (p == 0) return 1; // nの0乗は1
            else if (p % 2 == 0)
            {
                var x = Pow(n, p / 2, mod);
                return (x * x) % mod;
            }
            else
            {
                return Pow(n, p - 1, mod) * n % mod;
            }
        }
    }
}

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

    }
}

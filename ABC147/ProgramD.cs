// https://drken1215.hatenablog.com/entry/2020/04/25/032000

using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var mod = (long)1e9 + 7;
            var n = long.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            /*
            list[0] = list[0] % mod;
            BigInteger result = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    var r = list[i] ^ list[j];
                    result += r;
                    Console.WriteLine(string.Format("{0}^{1}={2}", list[i], list[j], r));
                }
            }
            */

            // for (var i = 0; i < n - 1; i++)
            // {
            //     Console.WriteLine(i);
            //     var s = "";
            //     for (var j = i + 1; j < n; j++)
            //     {
            //         s += j.ToString() + ",";
            //     }
            //     Console.WriteLine("  " + s);
            // }

            var result = 0L;
            var twoFactor = 1L;
            for (var i = 0; i < 60; i++)
            {
                long even = 0, odd = 0;
                for (var j = 0; j < n; j++)
                {
                    if (((list[j] >> i) & 1) == 1)
                        odd++;
                    else
                        even++;
                }
                var add = (odd * even) % mod * twoFactor % mod;
                result = (result + add) % mod;
                // Console.WriteLine(string.Format("{0},{1},{2},{3},{4}", odd, even, twoFactor, add, result));
                twoFactor = (twoFactor * 2) % mod;
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var result = 1L;

            for (var i = n; i > 1; i--)
            {
                result = (result * i) % (long)(1e9 + 7);
            }

            result = 100000000 % (long)(1e9 + 7);
            Console.WriteLine(result);
        }

        // 再帰だと遅い
        // static double kaijo(double n)
        // {
        //     if (n == 2)
        //     {
        //         return 2;
        //     }
        //     return (n * kaijo(n - 1)) % (1e9 + 7);
        // }
    }
}

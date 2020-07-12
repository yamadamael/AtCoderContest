using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static int _count;
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var m = long.Parse(inputs[1]);
            var p = long.Parse(inputs[2]);
            // Console.WriteLine(string.Format("Pow: {0}, _count: {1}", PowMod(n, p, m), _count));
            Console.WriteLine(PowMod(n, p, m));
        }

        static long Pow(long n, long k)
        {
            _count++;
            if (k == 0) return 1;
            if (k == 2) return n * n;
            var isOdd = k % 2 == 0;
            var k2 = isOdd ? k / 2 : k - 1;
            var p = Pow(n, k2);
            return isOdd ? p * p : p * n;
        }

        static long PowMod(long n, long k, long m)
        {
            _count++;
            if (k == 0) return 1;
            var isOdd = k % 2 == 0;
            var k2 = isOdd ? k / 2 : k - 1;
            var p = PowMod(n, k2, m);
            return (isOdd ? p * p : p * n) % m;
        }
    }
}

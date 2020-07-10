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
            var n = long.Parse(inputs[0]);
            var m = long.Parse(inputs[1]);

            if (Math.Abs(n - m) > 1)
            {
                Console.WriteLine(0);
                return;
            }

            long nn = 1, nm = 1;
            for (var i = n; i > 1; i--)
            {
                nn = (nn * i) % (long)(1e9 + 7);
            }

            for (var i = m; i > 1; i--)
            {
                nm = (nm * i) % (long)(1e9 + 7);
            }

            var key = nn == nm ? 2 : 1;

            Console.WriteLine((nn * nm) % ((long)1e9 + 7) * key % ((long)1e9 + 7));
        }
    }
}

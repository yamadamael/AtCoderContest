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
            long t = 1, a = 1;

            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                var tn = long.Parse(inputs[0]);
                var an = long.Parse(inputs[1]);

                // 解けるけどTLE
                // countをざっくり出してcount++してくパターン
                // var tc = t % tn == 0 ? t / tn : 1;
                // var ac = a % an == 0 ? a / an : 1;
                // var count = Math.Max(tc, ac);
                // if (count == 1)
                // {
                //     count = tn > an ? tn : an;
                // }

                var tc = (t / tn) + ((t % tn != 0) ? 1L : 0L);
                var ac = (a / an) + ((a % an != 0) ? 1L : 0L);
                var count = Math.Max(tc, ac);

                t = tn * count;
                a = an * count;
            }

            Console.WriteLine(t + a);
        }
    }
}

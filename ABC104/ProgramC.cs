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
            var d = int.Parse(inputs[0]);
            var g = int.Parse(inputs[1]);

            var pList = new int[d];
            var cList = new int[d];
            for (var i = 0; i < d; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                pList[i] = int.Parse(inputs1[0]);
                cList[i] = int.Parse(inputs1[1]);
            }

            var ans = int.MaxValue;
            for (var i = 0; i < 1 << d; i++)
            {
                var num = 0;
                var s = 0;
                var restMax = 0;
                for (var j = 0; j < d; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        s += 100 * (j + 1) * pList[j] + cList[j];
                        num += pList[j];
                    }
                    else
                    {
                        restMax = j;
                    }
                }

                if (s < g)
                {
                    var p = 100 * (restMax + 1);
                    var need = (g - s + (p - 1)) / p;
                    if (need >= pList[restMax])
                        continue;
                    num += need;
                }
                ans = Math.Min(ans, num);
            }

            Console.WriteLine(ans);
        }
    }
}

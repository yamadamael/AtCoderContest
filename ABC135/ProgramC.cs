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
            var a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            var b = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            var result = 0L;

            // for (var i = 0; i < n; i++)
            // {
            //     var sum = a[i] + a[i + 1];

            //     if (sum <= b[i])
            //     {
            //         result += sum;
            //         a[i + 1] = 0;
            //     }
            //     else
            //     {
            //         result += b[i];
            //         a[i + 1] -= Math.Max(b[i] - a[i], 0);
            //     }
            // }

            for (var i = 0; i < n; i++)
            {
                var min = Math.Min(a[i], b[i]);
                result += min;

                b[i] -= min;
                if (b[i] > 0)
                {
                    var min2 = Math.Min(a[i + 1], b[i]);
                    result += min2;
                    a[i + 1] -= min2;
                }
                // Console.WriteLine(string.Join(", ", min, min2));
            }

            Console.WriteLine(result);
        }
    }
}

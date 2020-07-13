using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            var list = new int[n];
            for (var i = 0; i < n; i++)
            {
                list[i] = 1 << i;
            }
            for (var i = 0; i < m; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var x = int.Parse(inputs1[0]) - 1;
                var y = int.Parse(inputs1[1]) - 1;
                // x
                var xb = 1 << x;
                list[y] = list[y] | xb;
                // y
                var yb = 1 << y;
                list[x] = list[x] | yb;
            }

            // for (var i = 0; i < n; i++)
            // {
            //     var bit = Convert.ToString(list[i], 2);
            //     var pad = n - bit.Length;

            //     Console.WriteLine(string.Format("{0}{1}", new string('0', pad), bit));
            // }

            var count = 0;
            for (var i = 0; i < 1 << n; i++)
            {
                var b = (1 << n) - 1;
                var c = 0;
                for (var j = 0; j < n; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        c++;
                        b = b & list[j];
                    }
                    if ((b & i) != i)
                        break;
                }

                if (b == i)
                {
                    // Console.WriteLine(string.Format("{0}, {1}", i, c));
                    count = Math.Max(count, c);
                }
            }

            Console.WriteLine(count);
        }
    }
}

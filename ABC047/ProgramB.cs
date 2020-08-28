using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var w = int.Parse(inputs[0]);
            var h = int.Parse(inputs[1]);
            var n = int.Parse(inputs[2]);

            var left = 0;
            var right = w;
            var bottom = 0;
            var top = h;

            for (var i = 0; i < n; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var x = int.Parse(inputs1[0]);
                var y = int.Parse(inputs1[1]);
                var a = int.Parse(inputs1[2]);

                switch (a)
                {
                    case 1:
                        left = Math.Max(left, x);
                        break;
                    case 2:
                        right = Math.Min(right, x);
                        break;
                    case 3:
                        bottom = Math.Max(bottom, y);
                        break;
                    case 4:
                        top = Math.Min(top, y);
                        break;
                }
            }

            var nw = right - left;
            var nh = top - bottom;
            if (nw < 0 || nh < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var result = Math.Max(0, nw * nh);
                Console.WriteLine(result);
            }
        }
    }
}

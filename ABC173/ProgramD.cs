using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            var result = 0L;

            list.Sort((a, b) => b - a);

            // long right, left;
            // right = list[0];
            // left = list[0];

            // for (var i = 1; i < n; i++)
            // {
            //     if (right > left)
            //     {
            //         result += left;
            //         right = list[i];
            //     }
            //     else
            //     {
            //         result += right;
            //         left = list[i];
            //     }
            // }
            var t = n - 1;

            for (var i = 0; i < n; i++)
            {
                var count = i == 0 ? 1 : 2;
                for (var j = 0; j < count; j++)
                {
                    if (t > 0)
                    {
                        result += list[i];
                        t--;
                    }
                }
            }

            Console.WriteLine(result);
        }

    }
}

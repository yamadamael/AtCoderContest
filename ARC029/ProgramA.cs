using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new int[n];
            for (var i = 0; i < n; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
            }

            var result = int.MaxValue;

            for (var i = 0; i < 1 << n; i++)
            {
                int left = 0, right = 0;
                for (var j = 0; j < n; j++)
                {
                    if (((i >> j) & 1) == 0)
                        left += list[j];
                    else
                        right += list[j];
                }
                var r = Math.Max(left, right);
                result = Math.Min(result, r);
            }

            Console.WriteLine(result);
        }
    }
}

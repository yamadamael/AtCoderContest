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
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var result = int.MaxValue;

            for (var t = 0; t < n - 1; t++)
            {
                var s1 = 0;
                var s2 = 0;
                for (var j = 0; j < n; j++)
                {
                    if (t >= j)
                        s1 += list[j];
                    else
                        s2 += list[j];
                }

                // Console.WriteLine(string.Format("{0}: {1}, {2}", t, s1, s2));
                result = Math.Min(result, Math.Abs(s1 - s2));
            }

            Console.WriteLine(result);
        }
    }
}

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
            var p = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            var q = p.OrderBy(x => x).ToArray();

            var result = false;
            var diff = 0;
            for (var i = 0; i < n; i++)
            {
                if (p[i] != q[i])
                {
                    diff++;
                }
            }

            if (diff == 0 || diff == 2)
            {
                result = true;
            }

            Console.WriteLine(result ? "YES" : "NO");
        }
    }
}

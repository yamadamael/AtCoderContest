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
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            if (list.Contains(0))
            {
                Console.WriteLine(0);
                return;
            }

            var result = 1L;
            for (var i = 0; i < n; i++)
            {
                var r = 1e18 / list[i];
                if (r < result)
                {
                    result = -1;
                    break;
                }
                result *= list[i];
            }

            if (result > (long)1e18)
                Console.WriteLine(-1);
            else
                Console.WriteLine(result);
        }
    }
}

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
            var a = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            var b = a.Where(x => x % 2 == 0).ToList();

            var r = 0;
            for (var i = 0; i < b.Count; i++)
            {
                if (b[i] % 3 == 0 || b[i] % 5 == 0)
                {
                    r++;
                }
            }

            Console.WriteLine(r == b.Count ? "APPROVED" : "DENIED");
        }
    }
}

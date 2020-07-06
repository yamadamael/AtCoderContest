using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            var n = list.Count;

            var dist = list.Distinct();
            foreach (var d in dist)
            {
                if (list.Count(x => x == d) == 1)
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}

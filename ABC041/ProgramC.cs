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
            var list = Console.ReadLine().Split(" ").Select((x, i) => (i + 1, long.Parse(x))).ToList();
            list = list.OrderByDescending((a) => a.Item2).ToList();
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(list[i].Item1);
            }
        }
    }
}

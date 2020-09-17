using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var n = list.Max();
            var r = list.OrderBy(x => Math.Abs(x - n / 2.0)).ThenBy(x => x).First();
            Console.WriteLine($"{n} {r}");
        }
    }
}

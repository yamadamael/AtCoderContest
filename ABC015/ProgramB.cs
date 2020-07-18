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
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            list = list.Where(x => x > 0).ToList();
            var result = Math.Ceiling(list.Average());
            Console.WriteLine(result);
        }
    }
}

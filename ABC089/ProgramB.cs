using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => x).ToList();
            list = list.Distinct().ToList();
            var result = list.Count == 3 ? "Three" : "Four";
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            var list2 = list.Distinct().ToList();
            Console.WriteLine(list.Count == list2.Count ? "YES" : "NO");
        }
    }
}

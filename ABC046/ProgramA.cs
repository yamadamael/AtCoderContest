using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).Distinct().ToList();
            Console.WriteLine(list.Count);
        }
    }
}

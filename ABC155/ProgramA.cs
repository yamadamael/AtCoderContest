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
            list = list.Distinct().ToList();
            var result = list.Count == 2 ? "Yes" : "No"; ;
            Console.WriteLine(result);
        }
    }
}

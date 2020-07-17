using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            list.Sort();
            var result = list[0] + list[1];
            Console.WriteLine(result);
        }
    }
}

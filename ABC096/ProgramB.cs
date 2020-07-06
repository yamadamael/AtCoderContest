using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            var k = long.Parse(Console.ReadLine());
            var max = list.Max();
            var index = list.IndexOf(max);

            list[index] *= (long)Math.Pow(2, k);

            Console.WriteLine(list.Sum());
        }
    }
}

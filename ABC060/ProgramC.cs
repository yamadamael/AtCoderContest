using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var t = long.Parse(inputs[1]);

            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            var result = 0L;

            for (var i = 1; i < n; i++)
            {
                var d = list[i] - list[i - 1];
                result += d > t ? t : d;
            }
            result += t;

            Console.WriteLine(result);
        }
    }
}

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
            var n = int.Parse(inputs[0]);
            var k = int.Parse(inputs[1]);
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            var result = 0d;

            list.Sort();

            for (var i = n - k; i < n; i++)
            {
                result = (result + list[i]) / 2d;
            }

            Console.WriteLine(result);
        }
    }
}

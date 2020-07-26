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

            var a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            for (var i = k; i < n; i++)
            {
                var result = a[i] > a[i - k];
                Console.WriteLine(result ? "Yes" : "No");
            }
        }
    }
}

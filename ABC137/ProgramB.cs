using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var k = long.Parse(inputs[0]);
            var x = long.Parse(inputs[1]);

            var list = new int[k * 2 - 1];
            var a = x - k - 1;
            for (var i = -(k - 1); i <= k - 1; i++)
            {
                Console.WriteLine(x + i);
            }
        }
    }
}

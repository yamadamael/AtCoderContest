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
            var h = long.Parse(inputs[0]);
            var w = long.Parse(inputs[1]);

            for (var i = 0; i < h; i++)
            {
                var s = Console.ReadLine();
                Console.WriteLine(s);
                Console.WriteLine(s);
            }
        }
    }
}

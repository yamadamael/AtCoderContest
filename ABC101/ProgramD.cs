using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            var a = long.Parse(Console.ReadLine());

            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var m = long.Parse(inputs[1]);
            var k = long.Parse(inputs[2]);

            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            var result = 0L;



            Console.WriteLine(result);
        }

    }
}

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
            var a = long.Parse(inputs[0]);
            var b = long.Parse(inputs[1]);
            var c = long.Parse(inputs[2]);
            var d = long.Parse(inputs[3]);

            var start = Math.Max(a, c);
            var end = Math.Min(b, d);

            var result = Math.Max(end - start,0);
 
            Console.WriteLine(result);
        }
    }
}

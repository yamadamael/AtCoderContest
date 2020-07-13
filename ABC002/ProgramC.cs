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
            var ax = long.Parse(inputs[0]);
            var ay = long.Parse(inputs[1]);
            var bx = long.Parse(inputs[2]) - ax;
            var by = long.Parse(inputs[3]) - ay;
            var cx = long.Parse(inputs[4]) - ax;
            var cy = long.Parse(inputs[5]) - ay;
            ax = ay = 0;

            var result = (bx * cy - cx * by) / 2f;

            Console.WriteLine(Math.Abs(result));
        }
    }
}

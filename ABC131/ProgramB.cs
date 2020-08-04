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
            var n = int.Parse(inputs[0]);
            var l = int.Parse(inputs[1]);
            var result = 0;

            var min = l;
            for (var i = 0; i < n; i++)
            {
                result += i + l;
                min = Math.Abs(min) < Math.Abs(i + l) ? min : i + l;
            }

            Console.WriteLine(result - min);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var x = long.Parse(inputs[0]);
            var t = long.Parse(inputs[1]);
            var result = x - t < 0 ? 0 : x-t;
            Console.WriteLine(result);
        }
    }
}

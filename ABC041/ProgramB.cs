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
            var result = a * b % (long)(1e9 + 7);
            result = result * c % (long)(1e9 + 7);
            Console.WriteLine(result);
        }
    }
}

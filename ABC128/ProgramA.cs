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
            var a = long.Parse(inputs[0]);
            var p = long.Parse(inputs[1]);
            p += a * 3;
            var result = p / 2;
            Console.WriteLine(result);
        }
    }
}

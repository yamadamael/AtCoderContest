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
            var b = long.Parse(inputs[1]);
            var x = long.Parse(inputs[2]);
            var result = a <= x && x <= a + b ? "YES" : "NO";
            Console.WriteLine(result);
        }
    }
}

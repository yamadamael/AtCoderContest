using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var a = double.Parse(inputs[0]);
            var b = double.Parse(inputs[1]);
            var n = double.Parse(inputs[2]);
            var x = Math.Min(b - 1, n);
            var result = Math.Floor(a * x / b) - (a * Math.Floor(x / b));
            Console.WriteLine(result);
        }
    }
}

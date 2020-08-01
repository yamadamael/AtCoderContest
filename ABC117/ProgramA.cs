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
            var t = double.Parse(inputs[0]);
            var x = double.Parse(inputs[1]);
            var result = t / x;
            Console.WriteLine(result);
        }
    }
}

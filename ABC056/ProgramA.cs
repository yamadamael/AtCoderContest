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
            var a = inputs[0] == "H";
            var b = inputs[1] == "H";
            var result = a == b ? "H" : "D";

            Console.WriteLine(result);
        }
    }
}

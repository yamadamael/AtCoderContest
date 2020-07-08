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
            var result = inputs[0][0].ToString() + inputs[1][0] + inputs[2][0];
            Console.WriteLine(result);
        }
    }
}

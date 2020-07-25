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
            var ab = long.Parse(inputs[0]);
            var bc = long.Parse(inputs[1]);
            var ca = long.Parse(inputs[2]);
            var result = (bc * ab) / 2;
            Console.WriteLine(result);
        }
    }
}

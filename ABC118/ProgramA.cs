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

            if (b % a == 0)
                Console.WriteLine(a + b);
            else
                Console.WriteLine(b - a);
        }
    }
}

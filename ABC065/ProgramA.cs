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
            var a = long.Parse(inputs[1]);
            var b = long.Parse(inputs[2]);

            if (a >= b)
            {
                Console.WriteLine("delicious");
            }
            else if (a + x >= b)
            {
                Console.WriteLine("safe");
            }
            else
            {
                Console.WriteLine("dangerous");
            }
        }
    }
}

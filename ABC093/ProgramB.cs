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
            var k = long.Parse(inputs[2]);
            var result = a - 1;

            for (var i = a; i < a + k; i++)
            {
                if (result < i && i <= b)
                {
                    Console.WriteLine(i);
                    result = i;
                }
            }

            for (var i = b - k + 1; i <= b; i++)
            {
                if (result < i)
                {
                    Console.WriteLine(i);
                    result = i;
                }
            }
        }
    }
}

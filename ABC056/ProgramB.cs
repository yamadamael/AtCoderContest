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
            var w = int.Parse(inputs[0]);
            var a = int.Parse(inputs[1]);
            var b = int.Parse(inputs[2]);
            var result = 0;
            if (a > b + w)
            {
                result = a - (b + w);
                result = result < 0 ? 0 : result;
            }
            else
            {
                result = b - (a + w);
                result = result < 0 ? 0 : result;
            }
            Console.WriteLine(result);
        }
    }
}

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
            var a = int.Parse(inputs[0]);
            var b = int.Parse(inputs[1]);
            var result = 0;

            if (a > b)
            {
                result = a - 1;
            }
            else
            {
                result = a;
            }

            Console.WriteLine(result);
        }
    }
}

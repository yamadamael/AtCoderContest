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
            var n = long.Parse(inputs[0]);
            var m = long.Parse(inputs[1]);
            var k = long.Parse(inputs[2]);

            var result = 0;

            for (var i = n; i <= m; i++)
            {
                if (i % k == 0)
                {
                    result++;
                }

            }

            Console.WriteLine(result);
        }
    }
}

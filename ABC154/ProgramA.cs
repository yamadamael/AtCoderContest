using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var inputs1 = Console.ReadLine().Split(" ");
            var s = inputs1[0];
            var t = inputs1[1];

            var inputs2 = Console.ReadLine().Split(" ");
            var a = long.Parse(inputs2[0]);
            var b = long.Parse(inputs2[1]);

            var u = Console.ReadLine();

            if (s == u)
            {
                a--;
            }
            else if (t == u)
            {
                b--;
            }

            Console.WriteLine(string.Join(" ", a, b));
        }
    }
}

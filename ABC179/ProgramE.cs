using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramE
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var x = int.Parse(inputs[1]);
            var m = int.Parse(inputs[2]);

            var result = (long)x;
            var list = new List<int>() { x };

            for (var i = 0; i < n - 1; i++)
            {
                var r1 = list.Last() % m;
                long r2 = r1 * r1;
                int r = (int)(r2 % m);
                Console.WriteLine(r);
                list.Add(r);
                result += r;
            }

            Console.WriteLine(result);
        }
    }
}

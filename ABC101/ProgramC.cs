using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var k = long.Parse(inputs[1]);

            var a = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            // var index = a.IndexOf(1);
            // var k2 = k - 1;
            // var forward = index / k2 + (index % k2 != 0 ? 1 : 0);
            // var back = (n - index - 1) / k2 + ((n - index - 1) % k2 != 0 ? 1 : 0);

            // Console.WriteLine(forward + back);
            var result = 0L;
            while (n > 0)
            {
                n -= k;
                result++;

                if (n <= 0)
                {
                    break;
                }
                n++;
            }
            Console.WriteLine(result);
        }
    }
}

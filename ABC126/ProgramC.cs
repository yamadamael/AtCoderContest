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

            var result = 0d;
            for (var i = 1L; i <= n; i++)
            {
                var m = i;
                // var count = 0;
                var tmp = 1d / n;
                while (m < k)
                {
                    m = m << 1;
                    tmp /= 2;
                    // count++;
                }

                result += tmp;
                // Console.WriteLine(string.Format("{0},{1}", i, count));
            }

            Console.WriteLine(result);
        }
    }
}

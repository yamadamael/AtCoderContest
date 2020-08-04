using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var k = long.Parse(Console.ReadLine());
            var a = 7L % k;
            var result = 1L;

            if (k % 2 == 0 || k % 5 == 0)
            {
                Console.WriteLine(-1);
                return;
            }

            var list = new List<long>();
            for (var i = 0; i <= k; i++)
            {
                if (a == 0)
                {
                    Console.WriteLine(result);
                    return;
                }
                a = (a * 10 + 7) % k;
                result++;
            }

            Console.WriteLine(-1);
        }
    }
}

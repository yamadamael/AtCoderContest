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
            var c = long.Parse(inputs[2]);

            var list = new List<long>();
            var count = 1L;

            while (true)
            {
                var m = (a * count) % b;
                if (list.Contains(m))
                {
                    // Console.WriteLine(count);
                    Console.WriteLine("NO");
                    return;
                }

                if ((m == 0 && c == 0) || (m != 0 && c % m == 0))
                {
                    break;
                }

                list.Add(m);
                count++;
            }

            // Console.WriteLine(count);
            Console.WriteLine("YES");
        }
    }
}

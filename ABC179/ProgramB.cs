using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var r = 0;
            var result = false;

            for (var i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Split(" ");
                var d1 = long.Parse(inputs[0]);
                var d2 = long.Parse(inputs[1]);

                if (d1 == d2)
                    r++;
                else
                    r = 0;

                if (r >= 3)
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}

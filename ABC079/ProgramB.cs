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
            var list = new long[87];
            list[0] = 2;
            list[1] = 1;
            for (var i = 2; i < n + 1; i++)
            {
                list[i] = list[i - 1] + list[i - 2];
            }

            Console.WriteLine(list[n]);
        }
    }
}

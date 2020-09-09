using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var x = long.Parse(Console.ReadLine());
            var d = 0L;

            for (var i = 1; i <= x; i++)
            {
                var a = d + i;
                if (i == x || a >= x)
                {
                    Console.WriteLine(i);
                    return;
                }
                d = a;
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var s = n / 1000 + 1;
            if (n % 1000 == 0)
                s--;
            var result = 1000 * s - n;
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var r = 0L;

            for (var i = 1; i < n; i++)
            {
                var a = (n - 1) / i;
                r += a;
            }

            Console.WriteLine(r);
        }
    }
}

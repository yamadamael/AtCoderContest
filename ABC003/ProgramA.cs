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
            var result = 0f;

            if (n % 2 == 0)
            {
                var m1 = n / 2;
                var m2 = m1 + 1;
                result = (m1 + m2) / 2f;
            }
            else
            {
                result = (n + 1) / 2;
            }

            Console.WriteLine(result * 10000);
        }
    }
}

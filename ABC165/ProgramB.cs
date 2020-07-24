using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var x = long.Parse(Console.ReadLine());
            var result = 0L;
            var a = 100L;
            while (a < x)
            {
                a = a + (a / 100L);
                result++;
            }

            Console.WriteLine(result);
        }
    }
}

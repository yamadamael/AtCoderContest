using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());
            var c = long.Parse(Console.ReadLine());
            var x = long.Parse(Console.ReadLine());

            var result = 0;
            for (var i = 0; i <= a; i++)
            {
                for (var j = 0; j <= b; j++)
                {
                    for (var k = 0; k <= c; k++)
                    {
                        if (i * 500 + j * 100 + k * 50 == x)
                        {
                            result++;
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}

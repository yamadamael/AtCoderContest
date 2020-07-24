using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var k = long.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split(" ");
            var a = long.Parse(inputs[0]);
            var b = long.Parse(inputs[1]);
            var result = false;

            for (var i = a; i <= b; i++)
            {
                if (i % k == 0)
                {
                    result = true;
                    break;
                }
            }
            Console.WriteLine(result ? "OK" : "NG");
        }
    }
}

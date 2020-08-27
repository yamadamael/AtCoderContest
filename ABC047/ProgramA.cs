using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var m = long.Parse(inputs[1]);
            var k = long.Parse(inputs[2]);
            var result = false;

            if (n + m == k) result = true;
            if (n + k == m) result = true;
            if (k + m == n) result = true;

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}

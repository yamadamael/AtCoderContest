using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var d = long.Parse(inputs[1]);
            var m = d * 2 + 1;
            var result = n / m;
            result += (n % m) > 0 ? 1 : 0;
            Console.WriteLine(result);
        }
    }
}

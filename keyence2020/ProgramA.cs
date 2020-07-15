using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var l = Math.Max(h, w);
            var result = (n + l - 1) / l;

            Console.WriteLine(result);
        }
    }
}

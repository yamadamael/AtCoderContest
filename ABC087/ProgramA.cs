using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var x = long.Parse(Console.ReadLine());
            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());

            var nx = x - a;
            var d = nx / b;

            Console.WriteLine(nx - (b * d));
        }
    }
}

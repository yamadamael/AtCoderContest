using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]); // s
            var m = long.Parse(inputs[1]); // c

            // s*1,c*2使うパターン
            var sm = m / 2;
            var s = Math.Min(n, sm);
            m -= s * 2;

            // c*4使うパターン
            var c = m / 4;

            Console.WriteLine(s + c);
        }
    }
}

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
            var a = inputs[0];
            var b = inputs[1];
            var c = inputs[2];

            if (a[a.Length - 1] != b[0] || b[b.Length - 1] != c[0])
            {
                Console.WriteLine("NO");
                return;
            }

            Console.WriteLine("YES");
        }
    }
}

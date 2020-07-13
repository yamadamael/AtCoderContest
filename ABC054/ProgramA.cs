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

            if (n == m)
            {
                Console.WriteLine("Draw");
                return;
            }

            if (n == 1)
            {
                Console.WriteLine("Alice");
                return;
            }
            if (m == 1)
            {
                Console.WriteLine("Bob");
                return;
            }

            if (n > m)
            {
                Console.WriteLine("Alice");
                return;
            }
            else
            {
                Console.WriteLine("Bob");
                return;
            }
        }
    }
}

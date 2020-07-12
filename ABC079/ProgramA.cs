using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var a0 = a / 1000;
            a = a % 1000;
            var a1 = a / 100;
            a = a % 100;
            var a2 = a / 10;
            var a3 = a % 10;

            var result = (a0 == a1 && a1 == a2) || (a1 == a2 && a2 == a3);
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var result = a % 2 == 0 ? a : 2 * a;
            Console.WriteLine(result);
        }
    }
}

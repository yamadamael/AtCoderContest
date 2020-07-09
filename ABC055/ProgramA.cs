using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var result = n * 800 - (n / 15) * 200;
            Console.WriteLine(result);
        }
    }
}

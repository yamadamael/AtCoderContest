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
            if (n < 1200)
                Console.WriteLine("ABC");
            else if (n < 2800)
                Console.WriteLine("ARC");
            else
                Console.WriteLine("AGC");
        }
    }
}

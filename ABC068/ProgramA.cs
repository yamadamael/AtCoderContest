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
            var result = "ABC" + a;
           Console.WriteLine(result);
        }
    }
}

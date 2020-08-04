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
            var result = 30 <= a ? "Yes" : "No";
            Console.WriteLine(result);
        }
    }
}

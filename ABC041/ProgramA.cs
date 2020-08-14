using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var i = int.Parse(Console.ReadLine());
            var result = s[i - 1];
            Console.WriteLine(result);
        }
    }
}

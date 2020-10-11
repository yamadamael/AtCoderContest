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
            var t = Console.ReadLine();
            var result = s == "Y" ? char.ToUpper(t[0]) : t[0];
            Console.WriteLine(result);
        }
    }
}

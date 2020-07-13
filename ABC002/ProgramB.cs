using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            s = s.Replace("a", "");
            s = s.Replace("i", "");
            s = s.Replace("u", "");
            s = s.Replace("e", "");
            s = s.Replace("o", "");
            Console.WriteLine(s);
        }
    }
}

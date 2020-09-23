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
            if (s[s.Length-1] == 's')
            {
                s += "es";
            }
            else
                s += "s";
            Console.WriteLine(s);
        }
    }
}

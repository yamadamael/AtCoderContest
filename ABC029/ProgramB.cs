using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var result = 0;
            for (var i = 0; i < 12; i++)
            {
                var s = Console.ReadLine();
                result = s.Contains('r') ? result + 1 : result;
            }
            Console.WriteLine(result);
        }
    }
}

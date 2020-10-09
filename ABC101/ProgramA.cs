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
            var result = 0L;

            result += s.Count(x => x == '+');
            result -= s.Count(x => x == '-');

            Console.WriteLine(result);
        }
    }
}

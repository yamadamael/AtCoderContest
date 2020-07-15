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
            var result = a + 1;
            if (result > 12)
                result = 1;
            Console.WriteLine(result);
        }
    }
}

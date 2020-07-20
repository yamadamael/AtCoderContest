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
            var s1 = int.Parse(s.Substring(0, 2));
            var s2 = int.Parse(s.Substring(2, 2));

            var r1 = 0 < s1 && s1 <= 12;
            var r2 = 0 < s2 && s2 <= 12;

            if (r1 && r2)
            {
                Console.WriteLine("AMBIGUOUS");
            }
            else if (r1)
            {
                Console.WriteLine("MMYY");
            }
            else if (r2)
            {
                Console.WriteLine("YYMM");
            }
            else
            {
                Console.WriteLine("NA");
            }
        }
    }
}

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

            if (s[0] != 'A')
            {
                Console.WriteLine("WA");
                return;
            }

            var cCount = 0;
            var cPos = -1;
            for (var i = 2; i < s.Length - 1; i++)
            {
                if (s[i] == 'C')
                {
                    cCount++;
                    cPos = i;
                }
            }
            if (cCount != 1)
            {
                Console.WriteLine("WA");
                return;
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (i == 0 || i == cPos) continue;
                if (!Char.IsLower(s[i]))
                {
                    Console.WriteLine("WA");
                    return;
                }
            }

            Console.WriteLine("AC");
        }
    }
}

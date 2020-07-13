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
            var result = true;

            for (var i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    result = false;
                    break;
                }
            }

            Console.WriteLine(result ? "YES" : "NO");
        }
    }
}

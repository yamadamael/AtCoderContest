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
            var result = 0;

            for (var i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}

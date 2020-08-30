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
            var t = Console.ReadLine();

            var result = 0;

            for (var i = 0; i < s.Length - t.Length + 1; i++)
            {
                var count = 0;
                for (var j = 0; j < t.Length; j++)
                {
                    if (s[i + j] == t[j])
                    {
                        count++;
                    }
                }
                result = Math.Max(result, count);
            }
            Console.WriteLine(t.Length - result);
        }
    }
}

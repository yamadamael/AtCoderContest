using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();

            var result = 0;
            var max = s.Distinct().Count();
            for (var i = 1; i < n; i++)
            {
                var s1 = s.Substring(0, i).Distinct().ToArray();
                var s2 = s.Substring(i).Distinct().ToArray();
                var count = 0;
                for (var j = 0; j < s1.Length; j++)
                {
                    if (s2.Contains(s1[j]))
                    {
                        count++;
                    }
                }
                result = Math.Max(result, count);
            }

            Console.WriteLine(result);
        }
    }
}

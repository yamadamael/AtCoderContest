using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            long[] resultCount = new long[4];
            string[] resultList = new string[] { "AC", "WA", "TLE", "RE" };

            for (var i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                for (var j = 0; j < 4; j++)
                {
                    if (s == resultList[j])
                    {
                        resultCount[j]++;
                    }
                }

            }

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine(resultList[i] + " x " + resultCount[i]);
            }
        }
    }
}

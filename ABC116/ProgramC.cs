using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var h = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            var l = new int[n];

            var result = 0;
            for (var i = 0; i < n; i++)
            {
                while (l[i] < h[i])
                {
                    result++;
                    var count = i;
                    // Console.WriteLine(string.Format("{0},{1}", i, count));
                    while (count < n && l[count] < h[count])
                    {
                        l[count]++;
                        // Console.WriteLine(string.Format("  {0},{1}", count, l[count]));
                        count++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();
            var result = n;

            // 気合い型(TLE)
            // for (var i = 0; i < n; i++)
            // {
            //     var left = s.Substring(0, i).Count(x => x == 'W');
            //     var righ = s.Substring(i + 1).Count(x => x == 'E');
            //     // Console.WriteLine(left + ", " + righ);
            //     result = Math.Min(result, left + righ);
            // }

            // 累積和
            var se = new int[n + 1];
            var sw = new int[n + 1];
            for (var i = 1; i < n + 1; i++)
            {
                se[i] = s[i - 1] == 'E' ? se[i - 1] + 1 : se[i - 1];
                sw[i] = s[i - 1] == 'W' ? sw[i - 1] + 1 : sw[i - 1];
            }

            for (var i = 0; i < (n + 1) - 1; i++)
            {
                var r1 = sw[i];
                var r2 = se[n] - se[i + 1];
                result = Math.Min(r1 + r2, result);
            }
            Console.WriteLine(result);
        }
    }
}
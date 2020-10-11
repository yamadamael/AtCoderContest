using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var h = long.Parse(inputs[0]);
            var w = long.Parse(inputs[1]);
            var slist = new List<string>();

            var result = 0L;
            for (var i = 0; i < h; i++)
            {
                var s = Console.ReadLine();
                slist.Add(s);
                for (var j = 0; j < w - 1; j++)
                {
                    if (s[j] == '.' && s[j + 1] == '.')
                    {
                        result++;
                    }
                }
            }

            for (var j = 0; j < w; j++)
            {
                for (var i = 0; i < h - 1; i++)
                {
                    if (slist[i][j] == '.' && slist[i + 1][j] == '.')
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}

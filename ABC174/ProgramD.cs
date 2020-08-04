using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var s = Console.ReadLine().Select(x => x).ToArray();

            var result = 0;
            var j = s.Length - 1;
            for (var i = 0; i < n; i++)
            {
                if (s[i] == 'W')
                {
                    for (; j > i; j--)
                    {
                        if (s[j] == 'R')
                        {
                            s[i] = 'R';
                            s[j] = 'W';
                            result++;
                            // Console.WriteLine(string.Join(",", i, j));
                            // Console.WriteLine(string.Join("", s));
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}

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
            var list = new int[5];

            for (var i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                switch (s[0])
                {
                    case 'M':
                        list[0]++;
                        break;
                    case 'A':
                        list[1]++;
                        break;
                    case 'R':
                        list[2]++;
                        break;
                    case 'C':
                        list[3]++;
                        break;
                    case 'H':
                        list[4]++;
                        break;
                }
            }

            var result = 0L;
            for (var i = 0; i < 32; i++)
            {
                var r = 1L;
                var count = 0;
                for (var j = 0; j < 5; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        count++;
                        r *= list[j];
                    }
                }
                if (count == 3)
                {
                    result += r;
                }
            }
            Console.WriteLine(result);
        }
    }
}

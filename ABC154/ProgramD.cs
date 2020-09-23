using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static long[] _sumList;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var k = int.Parse(inputs[1]);

            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            _sumList = new long[list.Max() + 1];
            func(list.Max());

            var result = 0d;
            var start = 0;
            var sum = 0L;
            var s = 0L;
            for (var i = 0; i < n; i++)
            {
                var tmp = $"{i} {list[i]}";
                sum += list[i];
                if (i - k >= 0)
                {
                    tmp += " cut";
                    sum -= list[(int)(i - k)];
                }

                if (i - (k - 1) >= 0)
                {
                    tmp += " point";
                    if (s < sum)
                    {
                        tmp += " over";
                        start = i - k + 1;
                        s = sum;
                    }
                }
                Console.WriteLine(tmp);
            }

            for (var i = start; i < start + k; i++)
            {
                result += _sumList[(int)list[i]] / (double)list[i];
            }

            Console.WriteLine(result);
        }

        static long func(long l)
        {
            if (l == 1)
            {
                return 1;
            }

            _sumList[l] = l + func(l - 1);
            return _sumList[l];
        }
    }
}

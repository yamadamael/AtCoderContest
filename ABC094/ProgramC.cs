using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static List<int> _list;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            _list = new List<int>(list);
            _list.Sort();
            var mean1 = _list[n / 2 - 1];
            var mean2 = _list[n / 2];

            for (var i = 0; i < n; i++)
            {
                var a = list[i];
                var index = BinarySearch3(a);
                var b = index < n / 2 ? mean2 : mean1;
                // Console.WriteLine(string.Join(", ", a, index, b));
                Console.WriteLine(b);
            }
        }

        static int BinarySearch3(int key)
        {
            int ng = -1;
            int ok = _list.Count;

            while (Math.Abs(ok - ng) > 1)
            {
                int mid = (ok + ng) / 2;

                if (isOk(mid, key))
                {
                    ok = mid;
                }
                else
                {
                    ng = mid;
                }
            }

            return ok;
        }

        // indexが条件を満たすかどうか
        static bool isOk(int index, int key)
        {
            return _list[index] >= key;
        }
    }
}

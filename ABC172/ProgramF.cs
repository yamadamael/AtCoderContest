using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramF
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var aList = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            var a0 = aList[0];
            var a1 = aList[1];
            var ans = 0L;

            // if (a0 > a1)
            // {
            //     for (var i = 0L; i < a0; i++)
            //     {
            //         aList[0] = a0 - i;
            //         aList[1] = a1 + i;

            //         if (xor(n, aList) == 0)
            //         {
            //             ans = i;
            //             break;
            //         }
            //     }
            // }

            // if (a0 > a1 && (a0 + a1) % 2 == 0)
            // {
            //     var ave = (a0 + a1) / 2;
            //     ans = a0 - ave;
            // }

            // var sum = -a0 + aList.Sum();
            // var bitCount = getBitCount(a0);
            // var and = (1L << (bitCount + 1)) - 1L;
            // Console.WriteLine("sum: " + sum + ", bitCount; " + bitCount + ", and: " + and);
            // var sum2 = sum & and;

            // if ((a0 + sum2) % 2 == 0)
            // {
            //     var ave = (a0 + sum2) / 2;
            //     ans = a0 - ave;
            // }

            var backXor = xor(n, aList);
            for (var i = 0L; i < a0; i++)
            {
                aList[0] = a0 - i;
                aList[1] = a1 + i;

                if (((a0 - i) ^ (a1 + i)) == backXor)
                {
                    ans = i;
                    break;
                }
            }

            if (ans == 0)
            {
                ans = -1;
            }
            Console.WriteLine(ans);
        }

        // 最初の山と2つ目の山以外の排他的論理和
        static long xor(int n, List<long> list)
        {
            var result = 0L;
            for (var i = 2; i < n; i++)
            {
                result ^= list[i];
            }
            return result;
        }

        static int getBitCount(long n)
        {
            var count = 0;
            while (n > 1)
            {
                n = n >> 1;
                count++;

                if (n == 0)
                {
                    break;
                }
            }

            return count;
        }
    }
}

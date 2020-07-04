using System;
using System.Linq;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);
            var k = int.Parse(inputs[2]);

            var aList = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            var bList = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            var minute = 0L;
            var i = 0;
            var j = 0;
            var count = 0;

            // bmax
            minute = bList.Sum();
            j = m;

            // aを増やすためのループ
            for (i = 0; i < n + 1; i++)
            {
                // b減らす
                while (minute > k && j > 0)
                {
                    j--;
                    minute -= bList[j];
                }

                // aだけで時間超過している場合終了
                if (minute > k) break;

                // 更新
                count = Math.Max(count, i + j);

                // 最後の更新が終わったら離脱
                if (i == n) break;

                // a増やす
                minute += aList[i];
            }

            Console.WriteLine(count);
        }
    }
}

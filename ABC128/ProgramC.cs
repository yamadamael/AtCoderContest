using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            var list = new List<int>[m];

            for (var i = 0; i < m; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x) - 1).ToList();
                inputs1.RemoveAt(0);
                list[i] = inputs1;
            }

            var p = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            var result = 0;

            for (var i = 0; i < (1 << n); i++)
            {
                var r = true;

                // 電球ループ
                for (var j = 0; j < m; j++)
                {
                    var switchs = list[j];
                    var onCount = 0;

                    // スイッチループ
                    for (var k = 0; k < switchs.Count; k++)
                    {
                        if (((i >> switchs[k]) & 1) == 1)
                        {
                            onCount++;
                        }
                    }

                    // onCount比較して点灯チェック
                    if (!(onCount % 2 == p[j]))
                    {
                        r = false;
                        break;
                    }
                }

                if (r)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}

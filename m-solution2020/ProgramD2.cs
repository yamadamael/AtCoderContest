using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD2
    {
        // ACできなかったやつ
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

            var money = 1000;

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(i);
                var up = i;
                var down = i;
                var ud = i + 1 < n && list[i] < list[i + 1];
                for (var j = i + 1; j < n; j++)
                {
                    if (ud)
                    {
                        if (list[up] < list[j])
                            up = j;
                        else
                            break;
                    }

                    if (!ud)
                    {
                        if (list[down] > list[j])
                            down = j;
                        else
                            break;
                    }
                }

                if (down == i && down < up)
                {
                    var kabu = money / list[down];
                    money -= kabu * list[down];
                    money += kabu * list[up];
                    Console.WriteLine(string.Format("  {0}, {1}, {2}, {3}", down, up, kabu, money));
                    i = up;
                    continue;
                }
            }

            Console.WriteLine(money);
        }

    }
}

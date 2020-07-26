using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD3
    {
        // 解説の写経
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            var money = 1000L;

            for (var i = 0; i < n - 1; i++)
            {
                if (list[i] < list[i + 1])
                {
                    var kabu = money / list[i];
                    money += kabu * (list[i + 1] - list[i]);
                }
            }

            Console.WriteLine(money);
        }
    }
}

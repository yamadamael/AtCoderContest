using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var num = new int[3];
            var inputs = Console.ReadLine().Split(" ");
            num[0] = int.Parse(inputs[0]);
            num[1] = int.Parse(inputs[1]);
            num[2] = int.Parse(inputs[2]);

            var result = 0;

            while (true)
            {
                if (num[0] == num[1] && num[0] == num[2])
                {
                    Console.WriteLine(result);
                    return;
                }

                result++;

                var min = num.Min();
                var minCount = num.Count(x => x == min);

                for (var i = 0; i < 3; i++)
                {
                    if (num[i] == min)
                    {
                        num[i] += minCount == 1 ? 2 : 1;
                    }
                }
            }

        }
    }
}

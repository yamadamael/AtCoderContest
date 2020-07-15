using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        struct Bridge
        {
            public int a;
            public int b;
        }
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            var list = new Bridge[m];
            for (var i = 0; i < m; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var a = int.Parse(inputs1[0]) - 1;
                var b = int.Parse(inputs1[1]) - 1;
                list[i] = new Bridge() { a = a, b = b };
            }

            var rList = new List<int>();
            list = list.OrderBy(x => x.b).ToArray();

            var result = 0;
            foreach (var b in list)
            {
                var isPath = true;
                foreach (var r in rList)
                {
                    if (b.a <= r && r < b.b)
                    {
                        isPath = false;
                        break;
                    }
                }

                if (isPath)
                {
                    rList.Add(b.b - 1);
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}

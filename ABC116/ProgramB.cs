using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { int.Parse(Console.ReadLine()) };
            var result = 1;

            while (true)
            {
                result++;
                var r = func(list.Last());
                if (list.Contains(r))
                {
                    break;
                }
                list.Add(r);
            }

            Console.WriteLine(result);
        }

        static int func(int n)
        {
            if ((n & 1) == 0)
            {
                return n / 2;
            }
            else
            {
                return 3 * n + 1;
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static int _ng1;
        static int _ng2;
        static int _ng3;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            _ng1 = int.Parse(Console.ReadLine());
            _ng2 = int.Parse(Console.ReadLine());
            _ng3 = int.Parse(Console.ReadLine());

            if (!judge(n))
            {
                Console.WriteLine("NO");
                return;
            }

            for (var i = 0; i < 100; i++)
            {
                if (judge(n - 3))
                {
                    n -= 3;
                    continue;
                }

                if (judge(n - 2))
                {
                    n -= 2;
                    continue;
                }

                if (judge(n - 1))
                {
                    n -= 1;
                    continue;
                }

                break;
            }

            Console.WriteLine(n <= 0 ? "YES" : "NO");
        }

        static bool judge(int n)
        {
            if (n == _ng1 || n == _ng2 || n == _ng3)
                return false;

            return true;
        }
    }
}

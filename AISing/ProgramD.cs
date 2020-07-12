using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramD
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = Console.ReadLine();
            var r = 0L;

            for (var i = 0; i < n; i++)
            {
                var result = 0;
                var nx = x;
                for (var j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        nx += x[i] == '1' ? '0' : '1';
                    }
                    else
                    {
                        nx += x[i];
                    }
                }


                var ix = Convert.ToUInt64("1", 2);

                while (n != 0)
                {




                    var p = popCount(x);


                }
                Console.WriteLine(result);
            }



        }

        static long StoL(string s)
        {
            var result = 0L;
            var start = s.Length - 1;
            for (var i = start; i >= 0; i++)
            {
                if (s[i] == '1')
                {
                    result += 1 << start - i;
                }
            }
            return result;
        }

        static int popCount(string s)
        {
            return s.Count(x => x == '1');
        }

        static int popCount(int n)
        {
            while (n == 0)
            {

            }
            return 0;
        }
    }
}

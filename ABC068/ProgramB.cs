using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var result = 0;

            for (var i = 0; i < 10; i++)
            {
                if ((1 << i) <= a)
                {
                    result = 1 << i;
                }
                else
                    break;
            }

            Console.WriteLine(result);
        }
    }
}

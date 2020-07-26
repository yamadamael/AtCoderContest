using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());

            var result = 0;

            if (a < 600)
                result = 8;
            else if (a < 800)
                result = 7;
            else if (a < 1000)
                result = 6;
            else if (a < 1200)
                result = 5;
            else if (a < 1400)
                result = 4;
            else if (a < 1600)
                result = 3;
            else if (a < 1800)
                result = 2;
            else if (a < 2000)
                result = 1;



            Console.WriteLine(result);
        }
    }
}

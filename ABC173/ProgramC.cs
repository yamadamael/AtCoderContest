using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        const int white = 0;
        const int black = 1;
        const int red = 2;

        static void Main(string[] args)
        {

            var inputs = Console.ReadLine().Split(" ");
            var h = long.Parse(inputs[0]);
            var w = long.Parse(inputs[1]);
            var k = long.Parse(inputs[2]);

            var matrix = new int[h, w];

            var result = 0;

            for (var i = 0; i < h; i++)
            {
                var list = Console.ReadLine().ToCharArray().Select(x => cnv(x)).ToList();
                for (var j = 0; j < w; j++)
                {
                    matrix[i, j] = list[j];
                }
            }

            for (var i = 0; i < h; i++)
            {
                for (var j = 0; j < w; j++)
                {
                    
                }
            }




            Console.WriteLine(result);
        }

        static int cnv(char c)
        {
            switch (c)
            {
                case '.':
                    return white;

                case '#':
                    return black;
            }

            Console.WriteLine("Default");
            return 0;
        }
    }
}

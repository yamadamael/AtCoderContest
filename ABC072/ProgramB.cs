﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var result = "";

            for (var i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += s[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}

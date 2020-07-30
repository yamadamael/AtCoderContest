using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            s = s.Substring(0, s.Length - 2);

            while (2 <= s.Length)
            {
                var b = true;
                for (var i = 0; i < s.Length / 2; i++)
                {
                    if (s.Length % 2 == 1 || s[i] != s[s.Length / 2 + i])
                    {
                        b = false;
                        break;
                    }
                }

                if (b)
                {
                    break;
                }

                s = s.Substring(0, s.Length - 2);
            }

            Console.WriteLine(s.Length);
        }
    }
}

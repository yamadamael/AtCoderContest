using System;
using System.Linq;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var t = Console.ReadLine();

            var sList = s.ToCharArray().Select(x => x.ToString()).ToList();
            var tList = t.ToCharArray().Select(x => x.ToString()).ToList();
            var count = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if(sList[i] != tList[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

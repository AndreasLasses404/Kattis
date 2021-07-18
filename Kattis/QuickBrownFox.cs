using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kattis
{
    class QuickBrownFox
    {
        public void Panagram()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                char[] finished = line.ToLower().ToArray();
                List<Char> missingLetters = new List<char>();
                StringBuilder sb = new StringBuilder();
                for (char j = 'a'; j <= 'z'; j++)
                {
                    if (!finished.Contains((char)j))
                        missingLetters.Add(j);
                }

                if (missingLetters.Count == 0)
                    Console.WriteLine("pangram");
                else
                {
                    Console.Write("missing ");
                    foreach (var l in missingLetters)
                    {
                        sb.Append(l);
                    }
                    Console.WriteLine(sb);
                }
            }
        }
    }
}

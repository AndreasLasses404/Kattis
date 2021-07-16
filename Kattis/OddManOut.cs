using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class OddManOut
    {
        public void OddMan()
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[] guests = Console.ReadLine().Split();
                Array.Sort(guests);
                int oddGuest = 0;
                for (int j = 0; j < n; j++)
                {
                    string tempGuest = guests[j];
                    int tempCount = 0;

                    for (int k = 0; k < n; k++)
                    {
                        if (guests[k] == tempGuest)
                        {
                            tempCount++;
                        }
                    }
                    if (tempCount == 1)
                    {
                        oddGuest = int.Parse(tempGuest);
                    }
                }

                Console.WriteLine("Case #{0}: {1}", i + 1, oddGuest);

            }
        }
    }
}


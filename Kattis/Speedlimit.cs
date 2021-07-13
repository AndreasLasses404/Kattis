using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Speedlimit
    {
        public void GetMiles()
        {
            int n = 0;

            while(n != -1)
            {
                n = int.Parse(Console.ReadLine());
                int tempTime = 0;
                int totalMiles = 0;
                for (int i = 0; i < n; i++)
                {
                    string[] get = Console.ReadLine().Split();
                    int s = int.Parse(get[0]);
                    int t = int.Parse(get[1]);

                    if (i == 0)
                    {
                        totalMiles += s * t;
                        tempTime = t;
                    }
                    else
                    {
                        totalMiles += s * (t - tempTime);
                        tempTime = t;
                    }
                }

                if(n != -1)
                {
                    Console.WriteLine(totalMiles + "miles");
                }
            }
        }
    }
}

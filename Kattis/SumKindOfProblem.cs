using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class SumKindOfProblem
    {
        //S=n(a+l)/2

        public void SumProblem()
        {
            int p = int.Parse(Console.ReadLine());

            for (int i = 0; i < p; i++)
            {
                string[] get = Console.ReadLine().Split();

                int k = int.Parse(get[0]);
                int n = int.Parse(get[1]);
                
                int s1 = (n * (n + 1)) / 2;
                int s2 = n * n;
                int s3 = n * (n + 1);


                Console.WriteLine("{0} {1} {2} {3}", k, s1, s2, s3);
                
            }
        }
    }
}

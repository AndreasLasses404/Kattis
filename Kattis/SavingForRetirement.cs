using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class SavingForRetirement
    {
        public void RetirementSavings()
        {
            string[] input = Console.ReadLine().Split();

            int bCurrentAge = int.Parse(input[0]);
            int bTargetAge = int.Parse(input[1]);
            int bSavings = int.Parse(input[2]);
            int bTotalSavings = bSavings * (bTargetAge - bCurrentAge);

            int aCurrentAge = int.Parse(input[3]);
            int aSavings = int.Parse(input[4]);
            int aTotalSavings = 0;
            int aTargetAge = aCurrentAge;

            while(aTotalSavings <= bTotalSavings)
            {
                aTotalSavings += aSavings;
                aTargetAge++;
            }

            Console.WriteLine(aTargetAge);
        }
    }
}

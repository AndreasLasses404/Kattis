using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    public class Tetration
    {
        public double Tetrationation()
        {
            double n = double.Parse(Console.ReadLine());

            return Math.Pow(n, (1 / n));
        }

    }
}

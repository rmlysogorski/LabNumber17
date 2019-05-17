using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    public class PrimeNumberGenerator
    {
        public static int GetPrimeNumber(int n)
        {
            int prime = 2;
            int count = 1;
            bool isPrime;
            for (int i = 3; count < n; i += 2)
            {
                isPrime = true;
                for (int j = 3; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    prime = i;
                    count++;
                }
            }
            return prime;
        }
    }
}

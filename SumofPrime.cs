using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    class sumofPrime
    {
        public static int SumofPrime(int st, int en)
        {
            int sum = 0;
            for (int i = en; i >= st; --i)
            {
                bool isPrime = isPrimeNumbe(i);
                if (isPrime)
                {
                    sum += i;
                }

            }

            return sum;
        }

        private static bool isPrimeNumbe(int num)
        {
            bool prime = true;
            for (int j = 2; j <= num; j++)
            {
                if (num % j == 0)
                {
                    prime = false;
                }
                prime = true;
            }



            return prime;
        }

        static void Main(string[] args)
        {
            int start = Inputs.GetNumber("Enter the 1st range");
            int end = Inputs.GetNumber("Enter The last range");

            Console.WriteLine(SumofPrime(start, end));

        }


    }
}

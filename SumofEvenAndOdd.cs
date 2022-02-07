using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    class SumofEvenAndOdd
    {
        static void GetEvenOdd(params int[] nums)
        {
            int SumofEven = 0;
            int SumofOdd = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    SumofEven += nums[i];
                }
                SumofOdd += nums[i];
            }

            Console.WriteLine($"The sum of Even Number is :{SumofEven},The Sum of Odd is {SumofOdd}");
        }

        static void Main(string[] args)
        {
            GetEvenOdd(1, 2, 3, 4, 5, 6, 7); 

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    class FibIndex
    {
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...

        static void fibonacci(int index)
        {
            int temp1 = 0;
            int temp2 = 1;
            int valIndex = 0;
            if (index == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= index; ++i)
                {
                    valIndex = temp1 + temp2;
                    temp1 += temp2;
                }
                Console.WriteLine(index);
                Console.WriteLine(valIndex);
                return;
            }

        }

        static void Main(string[] args)
        {
            fibonacci(2);
        }
    }
}

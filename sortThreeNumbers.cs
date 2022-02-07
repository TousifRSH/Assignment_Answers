using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    class sortThreeNumbers
    {
        public void sortThree(int a, int b, int c)
        {
            

            if (a < b && a < c)
            {
                if (b < c)
                {
                    Console.WriteLine($"ascending order:{a},{ b},{ c}");
                }
                else
                {
                    Console.WriteLine($"Ascending order :{a},{c},{b}");
                }
            }
            else if (b < a && b < c)
            {
                if (a < c)
                {
                    Console.WriteLine($"ascending order:{b},{a},{c}");

                }
                else
                {
                    Console.WriteLine($"ascending order:{b},{c},{a}");
                }
            }
            else if (c < a && c < b)
            {
                if (a < b)
                {
                    Console.WriteLine($"ascending order:{c},{a},{b}");
                }
                else
                {
                    Console.WriteLine($"Ascending order:{c},{b},{a}");
                }


            }
            else
            {
                Console.WriteLine("Print invalid");
            }
        }
        static void Main(string[] args)
        {
            sortThreeNumbers stn = new sortThreeNumbers();
            //a = Inputs.GetNumber("Enter Frsit Number:");
            //b = Inputs.GetNumber("Enter Second  Number:");
            //c = Inputs.GetNumber("Enter third Number:");
            
            //stn.sortThree();
            stn.sortThree(50,70,30);
            stn.sortThree(10, 90, 45);
            stn.sortThree(1008, 390, 6783);
        }

    }
}

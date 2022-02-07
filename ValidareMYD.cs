using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    class ValidareMYD
    {
        static bool GetLeafYear(int year, int month, int day)

        {
            bool result = false;
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    if ((month >= 1 && month <= 12) || (month == 2 && day <= 29))
                    {
                        return result = true;
                    }

                }
                return result = false;
            }

            else if (day <= 31)
            {

                result = true;
            }
            else if (month >= 1 && month <= 12)
            {
                return result = true;
            }

            return result;




        }
        static void Main(string[] args)
        {
            int year = Inputs.GetNumber("Enter The Year:");
            int month = Inputs.GetNumber("Enter The month:");
            int day = Inputs.GetNumber("Enter The day:");
            Console.WriteLine(GetLeafYear(year, month, day));

        }
    }
}

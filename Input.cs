using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    class Inputs
    {
        public static string GetAnswer(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetNumber(string Question)
        {
            string answer = GetAnswer(Question);
            return Convert.ToInt32(answer);
        }

    }
}

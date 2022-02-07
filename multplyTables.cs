using System;


namespace FinalAsignement
{
    class multplyTables
    {
        static void Main()
        {
            int fvalue = 1;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            while (favlue <= 10)
            {
                Console.WriteLine(num + "*" + fvalue + " = " + (num * fvalue));
                fvalue++;
            }
        }

}

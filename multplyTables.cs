using System;


namespace FinalAsignement
{
    class multplyTables
    {
        static void Main()
        {
            int a = 1;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            while (a <= 10)
            {
                Console.WriteLine(n + "*" + a + " = " + (n * a));
                a++;
            }
        }

}

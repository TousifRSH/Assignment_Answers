using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    class FileLowerCaseToUpperCase
    {
        static void Main()
        {

            string name = @"C:\Users\Tousif RSH\source\repos\FinalAsignement\FinalAsignement\TextFile1.txt";

            if (File.Exists(name))
            {
                StreamReader fileRw = File.OpenText(name);
                StreamWriter fileWr = File.CreateText(name + "uppercase" + ".csv");
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                    {
                        fileWr.WriteLine(line.ToUpper());
                        Console.WriteLine(line.ToUpper());
                    }
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
                if (File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }



        //Another Method
        //    public class ConvertTextFileToUppercase
        //    {
        //        public static void Main(string[] args)
        //        {
        //            string inputFileName = "input.txt";
        //            string outputFileName = "output.txt";

        //            string contents = File.ReadAllText(inputFileName);
        //            contents = contents.ToUpper();

        //            File.WriteAllText(outputFileName, contents);
        //        }
        //    }
        //}
    }

}
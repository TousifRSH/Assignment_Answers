using System;
using System.Collections.Generic;
using System.IO;

namespace testFile
{
    class Program
    {
        static void Main(string[] args)
        {
            AddData("144", "prassed", "Mumbai", "main.txt");
        }

        private static void AddData(string ID, string Name, string State, string filepath)
        {
            try
            {
                StreamWriter file;
                using (file = new StreamWriter(filepath, true))
                {
                    file.WriteLine(ID + "," + Name + "," + State);
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }
    }
}

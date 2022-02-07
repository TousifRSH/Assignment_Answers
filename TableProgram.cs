using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAsignement
{
    class TablePorgram
    {
        public int Width { get; set; }
        public int Height { set; get; }

        public TablePorgram(int Width, int Height)
        {
            if (Width >= 0) this.Width = Width;
            if (Height >= 0) this.Height = Height;
        }

        public void Showdata()
        {
            Console.WriteLine("Height - {0} cm, width - {1} cm", Height, Width);
        }

        static void Main(string[] args)
        {
            TablePorgram[] arr = new TablePorgram[10];
            Random value = new Random();
            for (int i = 0; i < 10; i++)
                arr[i] = new TablePorgram(value.Next(50, 200), value.Next(50, 200));
            foreach (var i in arr)
                i.Showdata();



        }
    }
}

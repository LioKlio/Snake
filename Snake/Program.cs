using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLine lineH1 = new HorizontalLine(0, 78, 0, "*");
            HorizontalLine lineH2 = new HorizontalLine(0, 78, 24, "*");
            lineH1.Drow();
            lineH2.Drow();

            VerticalLine lineV1 = new VerticalLine(0, 1, 24, "*");
            VerticalLine lineV2 = new VerticalLine(78, 0, 24, "*");
            lineV1.Drow();
            lineV2.Drow();

            Console.ReadLine();
        }
    }
}

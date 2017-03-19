using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontallLine line = new HorizontallLine(5, 10, 8, '+');
            line.DrawPH();

            VerticallLine line2 = new VerticallLine(5, 20, 5, '+');
            line2.DrawPV();

            Console.ReadLine();
        }

       
    }
}

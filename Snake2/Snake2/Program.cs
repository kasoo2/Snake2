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

            HorizontallLine lineL = new HorizontallLine(5, 10, 5, '+');
            lineL.Drow();

            HorizontallLine lineR = new HorizontallLine(5, 10, 20, '+');
            lineR.Drow();

            VerticallLine lineUp = new VerticallLine(5, 20, 5, '+');
            lineUp.Drow();

            VerticallLine lineDown = new VerticallLine(5, 20, 10, '+');
            lineDown.Drow();

            Console.ReadLine();
        }

       
    }
}

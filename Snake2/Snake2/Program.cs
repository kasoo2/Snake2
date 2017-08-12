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
            HorizontallLine rightLine = new HorizontallLine(0, 78, 0, '+');
            HorizontallLine leftLine = new HorizontallLine(0, 78, 24, '+');
            VerticallLine upLine = new VerticallLine(0, 24, 0, '+');
            VerticallLine downLine = new VerticallLine(0, 24, 79, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }

       
    }
}

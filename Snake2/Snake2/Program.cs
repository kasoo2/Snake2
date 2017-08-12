using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontallLine upLine = new HorizontallLine(0, 78, 0, '+');
            HorizontallLine downLine = new HorizontallLine(0, 78, 24, '+');
            VerticallLine leftLine = new VerticallLine(0, 24, 0, '+');
            VerticallLine rightLine = new VerticallLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            while (true)
            {
                snake.Move();
                Thread.Sleep(400);
            }
            

            Console.ReadLine();
        }

       
    }
}

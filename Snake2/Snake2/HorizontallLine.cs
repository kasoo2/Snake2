using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class HorizontallLine
    {
        List<Point> pList;

        public HorizontallLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void DrawPH()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

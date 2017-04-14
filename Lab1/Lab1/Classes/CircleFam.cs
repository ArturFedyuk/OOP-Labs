using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    abstract class CircleFam : MainPoint
    {
        protected int radius;

        protected Point ptFinish;

        protected List<Point> pts = new List<Point>();

        override public Point GetFinishPoint
        {
            get { return ptFinish; }
        }

        protected int calcRadius(Point ptStart, Point ptFinish)
        {
            int radius = Convert.ToInt16(Math.Sqrt(Math.Pow((ptStart.X - ptFinish.X), 2) + Math.Pow((ptStart.Y - ptFinish.Y), 2)));         
            return radius;
        }
    }
}

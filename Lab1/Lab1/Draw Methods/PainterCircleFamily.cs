using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1.Draw_Methods
{
    class PainterCircleFamily : ShapePainter
    {
        protected List<Point> pts = new List<Point>();

        protected int radius;
        
        protected int calcRadius(Point ptStart, Point ptFinish)
        {
            int radius = Convert.ToInt16(Math.Sqrt(Math.Pow((ptStart.X - ptFinish.X), 2) + Math.Pow((ptStart.Y - ptFinish.Y), 2)));
            return radius;
        }

        override public void DrawShape(Graphics gr)
        {
        }

        protected void delCoord()
        {
            pts.Clear();
        }

    }
}

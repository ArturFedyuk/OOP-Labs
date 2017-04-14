using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Draw_Methods
{
    class PentagonPainter : PainterCircleFamily
    {
        protected void SetCoords()
        {
            radius = calcRadius(ptStart, ptFinish);
            pts.Add(new Point(ptStart.X, ptStart.Y - radius));  // 1
            pts.Add(new Point((int)(ptStart.X + radius * Math.Cos(0.314)), (int)(ptStart.Y - radius * Math.Sin(0.314))));// 2
            pts.Add(new Point((int)(ptStart.X + radius * Math.Cos(0.942)), (int)(ptStart.Y + radius * Math.Sin(0.942))));// 3
            pts.Add(new Point((int)(ptStart.X - radius * Math.Cos(0.942)), (int)(ptStart.Y + radius * Math.Sin(0.942))));// 4
            pts.Add(new Point((int)(ptStart.X - radius * Math.Cos(0.314)), (int)(ptStart.Y - radius * Math.Sin(0.314))));// 5
            pts.Add(new Point(ptStart.X, ptStart.Y - radius));  // возвращение в начало
        }

        public override void DrawShape(Graphics gr)
        {
            SetCoords();
            for (int i = 0; i < pts.Count - 1; i++)
            {
                gr.DrawLine(pen, pts[i], pts[i + 1]);
            }
            delCoord();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Draw_Methods
{
    class TrianglePainter : PainterCircleFamily
    {
        private void SetCoords()
        {
            radius = calcRadius(ptStart, ptFinish);
            pts.Add(new Point(ptStart.X, ptStart.Y - radius));
            pts.Add(new Point((int)(ptStart.X + radius * Math.Cos(0.52)), (int)(ptStart.Y + radius * Math.Sin(0.52))));
            pts.Add(new Point((int)(ptStart.X - radius * Math.Cos(0.52)), (int)(ptStart.Y + radius * Math.Sin(0.52))));
            pts.Add(new Point(ptStart.X, ptStart.Y - radius));
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

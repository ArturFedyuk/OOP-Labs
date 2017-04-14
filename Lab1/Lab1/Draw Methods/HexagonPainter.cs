using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1.Draw_Methods
{
    class HexagonPainter : PainterCircleFamily
    {
        private void SetCoords()
        {
            radius = calcRadius(ptStart, ptFinish);
            int mult = (radius * radius) - ((radius / 2) * (radius / 2));
            mult = (int)Math.Sqrt(mult);
            pts.Add(new Point(ptStart.X - radius, ptStart.Y));  // 1
            pts.Add(new Point(ptStart.X - radius / 2, ptStart.Y + mult));   // 2
            pts.Add(new Point(ptStart.X + radius / 2, ptStart.Y + mult));   // 3
            pts.Add(new Point(ptStart.X + radius, ptStart.Y));  // 4
            pts.Add(new Point(ptStart.X + radius / 2, ptStart.Y - mult));   // 5
            pts.Add(new Point(ptStart.X - radius / 2, ptStart.Y - mult));   // 6
            pts.Add(new Point(ptStart.X - radius, ptStart.Y));  // возвращение в начало
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

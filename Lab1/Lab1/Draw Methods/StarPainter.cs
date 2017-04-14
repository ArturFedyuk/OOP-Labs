using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Draw_Methods
{
    class StarPainter : PentagonPainter
    {
        public override void DrawShape(Graphics gr)
        {
            SetCoords();
            gr.DrawLine(pen, pts[0], pts[2]);
            gr.DrawLine(pen, pts[0], pts[3]);
            gr.DrawLine(pen, pts[1], pts[3]);
            gr.DrawLine(pen, pts[1], pts[4]);
            gr.DrawLine(pen, pts[2], pts[4]);
            delCoord();
        }
    }
}

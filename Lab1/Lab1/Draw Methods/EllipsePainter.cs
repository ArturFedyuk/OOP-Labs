using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1.Draw_Methods
{
    class EllipsePainter : PainterLineFamily
    {
        public override void DrawShape(Graphics gr)
        {
            SetWHParams();
            gr.DrawEllipse(pen, ptStart.X, ptStart.Y, width, height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Draw_Methods
{
    class RectanglePainter : PainterLineFamily
    {
        public override void DrawShape(Graphics gr)
        {
            SetWHParams();
            gr.DrawRectangle(pen, ptStart.X, ptStart.Y, width, height);
        }
    }
}

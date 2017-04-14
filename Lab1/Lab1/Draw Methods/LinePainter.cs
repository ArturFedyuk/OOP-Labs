using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab1.Draw_Methods
{
    class LinePainter : PainterLineFamily
    {
        public override void DrawShape(Graphics gr)
        {
            gr.DrawLine(pen, ptStart, ptFinish);
        }
    }
}

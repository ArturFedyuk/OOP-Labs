using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1.Draw_Methods
{
    abstract class PainterLineFamily : ShapePainter
    {
        protected int width;

        protected int height;

        protected void SetWHParams()
        {
            if (ptStart.X > ptFinish.X)
            {
                int tmp = ptStart.X;
                ptStart.X = ptFinish.X;
                ptFinish.X = tmp;
            }
            if (ptStart.Y > ptFinish.Y)
            {
                int tmp = ptStart.Y;
                ptStart.Y = ptFinish.Y;
                ptFinish.Y = tmp;
            }
            width = Math.Abs(ptStart.X - ptFinish.X);
            height = Math.Abs(ptStart.Y - ptFinish.Y);
        }
    }
}

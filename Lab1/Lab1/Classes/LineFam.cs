using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    abstract class LineFam : MainPoint
    {
        protected Point ptFinish;

        protected int width;

        protected int height;
        
        override public Point GetFinishPoint
        {
            get { return ptFinish; }
        }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab1
{
    class Line : LineFam
    {
        public Line(Point ptStart, Point ptFinish)
        {
            try
            {
                this.ptStart = ptStart;
                this.ptFinish = ptFinish;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        public Line()   
        {
            ptStart = new Point(0, 0);
            ptFinish = new Point(0, 0);
        }

       /* public override void delCoord()
        {
         //   pts.Clear();
        }
        */
        override public void setCoordSt(Point ptStart)
        {
            this.ptStart = ptStart;
        }

        override public Point GetFinishPoint
        {
            get { return ptFinish; }
        }

        override public void setCoordF(Point ptFinish)
        {
            this.ptFinish = ptFinish;
        }

    /*    override public void DrawShape(Graphics gr)
        {
            gr.DrawLine(pen, ptStart, ptFinish);
        }       */
    }
}


/*     public Line(Color clr, int Width, Point ptStart, Point ptFinish)
        {
            try
            {
                pen.Color = clr;
                pen.Width = Width;
                this.ptStart = ptStart;
                this.ptFinish = ptFinish;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }
     */ 
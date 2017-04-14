using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    class Triangle : CircleFam
    { 
        public Triangle(Point ptStart, Point ptFinish) 
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
        
        public Triangle()
        {
        }

        public override void setCoordSt(Point ptStart)
        {
            this.ptStart = ptStart;
        }

        public override void setCoordF(Point ptFinish)
        {
            this.ptFinish = ptFinish;
        }

   /*     public override void delCoord()
        {
            pts.Clear();
        }
        */
        private void SetCoords()
        {
            radius = calcRadius(ptStart, ptFinish);
            pts.Add(new Point(ptStart.X, ptStart.Y - radius));
            pts.Add(new Point((int)(ptStart.X + radius * Math.Cos(0.52)), (int)(ptStart.Y + radius * Math.Sin(0.52))));
            pts.Add(new Point((int)(ptStart.X - radius * Math.Cos(0.52)), (int)(ptStart.Y + radius * Math.Sin(0.52))));
            pts.Add(new Point(ptStart.X, ptStart.Y - radius));
        }

  /*      override public void DrawShape(Graphics gr)
        { 
            SetCoords();
            for (int i = 0; i < pts.Count - 1; i++)
            {
                gr.DrawLine(pen, pts[i], pts[i + 1]);
            }
            delCoord();
        }*/
    }
}


/*    pts.Add(new Point(ptStart.X, ptStart.Y));
    pts.Add(new Point(ptStart.X + widthT / 2, ptStart.Y + height));
    pts.Add(new Point(ptStart.X - widthT / 2, ptStart.Y + height));
    pts.Add(new Point(ptStart.X, ptStart.Y));*/


    /*    public Triangle(Color clr, int Width, Point ptStart, Point ptFinish) 
        {
            try
            {
                this.ptStart = ptStart;
                this.ptFinish = ptFinish;
                pen.Color = clr;
                pen.Width = Width;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        */
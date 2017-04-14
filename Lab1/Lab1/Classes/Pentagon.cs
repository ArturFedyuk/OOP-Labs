using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Pentagon : CircleFam
    {
      //  protected List<Point> pts = new List<Point>();

        public Pentagon(Point ptStart, Point ptFinish)
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
        
        public override void setCoordF(Point ptFinish)
        {
            this.ptFinish = ptFinish;
        }

        public override void setCoordSt(Point ptStart)
        {
            this.ptStart = ptStart;
        }

        protected void SetCoords()
        {
            radius = calcRadius(ptStart, ptFinish);
            pts.Add(new Point(ptStart.X, ptStart.Y - radius));  // 1
            pts.Add(new Point((int)(ptStart.X + radius * Math.Cos(0.314)), (int)(ptStart.Y - radius * Math.Sin(0.314))));// 2
            pts.Add(new Point((int)(ptStart.X + radius * Math.Cos(0.942)), (int)(ptStart.Y + radius * Math.Sin(0.942))));// 3
            pts.Add(new Point((int)(ptStart.X - radius * Math.Cos(0.942)), (int)(ptStart.Y + radius * Math.Sin(0.942))));// 4
            pts.Add(new Point((int)(ptStart.X - radius * Math.Cos(0.314)), (int)(ptStart.Y - radius * Math.Sin(0.314))));// 5
            pts.Add(new Point(ptStart.X, ptStart.Y - radius));  // возвращение в начало
        }

        public Pentagon()
        {
        }
    }
}



/*       public Pentagon(Color clr, int Width, Point ptStart, Point ptFinish)
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

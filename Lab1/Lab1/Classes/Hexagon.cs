using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Hexagon : CircleFam
    {
        //private List<Point> pts = new List<Point>();

        public Hexagon(Point ptStart, Point ptFinish)
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
        
        public Hexagon()
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

        private void SetPoints()
        {
            radius = calcRadius(ptStart, ptFinish);
            if ((ptStart.X - radius > 0) && (ptStart.Y - radius > 0))
            {
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
        }

  /*      public override void delCoord()
        {
            pts.Clear();
        }
        */
  /*      public override void DrawShape(Graphics gr)
        {
            SetPoints();
            for (int i = 0; i < pts.Count - 1; i++)
            {
                gr.DrawLine(pen, pts[i], pts[i + 1]);
            }
            delCoord();
        }*/
    }
}



/*       public Hexagon(Color clr, int Width, Point ptStart, Point ptFinish)
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

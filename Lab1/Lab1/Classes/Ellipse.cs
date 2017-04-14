using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Ellipse : LineFam
    {
        public Ellipse(Point ptStart, Point ptFinish)
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
        
        public Ellipse()
        {
        }

        public override void setCoordF(Point ptFinish)
        {
            this.ptFinish = ptFinish;
        }

        public override void setCoordSt(Point ptStart)
        {
            this.ptStart = ptStart;
        }
    }
}



/*     public Ellipse(Color clr, int Width, Point ptStart, Point ptFinish)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    class Rectangle : LineFam
    {
        public Rectangle(Point ptStart, Point ptFinish)
        {
            try
            {
                this.ptFinish = ptFinish;
                this.ptStart = ptStart;
                SetWHParams();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        public Rectangle()
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
    }
}

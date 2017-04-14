using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    abstract class MainPoint : ICloneable
    {
        protected Pen pen;

        protected Point ptStart;
        
   //     protected List<Point> pts = new List<Point>();

        public MainPoint()
        {
            pen = new Pen(Color.Black, 1);
        }
        
        public MainPoint(Color cl, int width)
        {
            pen = new Pen(cl, width);
        }

        public Point GetStartPoint
        {
            get { return ptStart; }
        }
        
        virtual public Point GetFinishPoint
        {
            get;
        }
        abstract public void setCoordSt(Point ptStart);

        abstract public void setCoordF(Point ptFinish);

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        virtual public void SetPenColor(Color clr)
        {
            pen.Color = clr;
        }

        virtual public void SetPenWidth(int Width)
        {
            pen.Width = Width;
        }
    }
}

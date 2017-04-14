using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace Lab1.Draw_Methods
{
    abstract class ShapePainter
    {
        protected List<MainPoint> Shapes = new List<MainPoint>();

        protected Pen pen;

        abstract public void DrawShape(Graphics gr);

        protected Point ptStart;

        protected Point ptFinish;

        public void AddShape(MainPoint shape)
        {
            Shapes.Add(shape);
        }

        public void PaintAll(Graphics gr)
        {
            foreach (MainPoint mp in Shapes)
            {
                ptStart = mp.GetStartPoint;
                ptFinish = mp.GetFinishPoint;
                DrawShape(gr);
            }
        }

        public ShapePainter()
        {
            pen = new Pen(Color.Black, 1);
        }

        public Point SetStartPoint
        {
            set { ptStart = value; }
        }

        public Point SetFinishPoint
        {
            set { ptFinish = value; }
        }

        public void SetPenSettings(Color clr, int width)
        {
            pen.Color = clr;
            pen.Width = width;
        }
    }
}

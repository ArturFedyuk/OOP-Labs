using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Lab1.Draw_Methods;

namespace Lab1
{
    class ShapeController
    {
        protected List<MainPoint> Shapes = new List<MainPoint>();

        private Pen pen;

        public void AddShape(MainPoint shape)
        {
            Shapes.Add(shape);
        }

        public void DrawShapes(Graphics gr)
        {
            for (int i = 0; i < Shapes.Count; i++)
            {
              //  Shapes[i].DrawShape(gr);
            }
        }

        public void PaintAll(Graphics gr)
        {
            foreach (MainPoint mp in Shapes)
            {
                
            }
        }

        public void DelShapes()
        {
            Shapes.Clear();
        }
    }
}

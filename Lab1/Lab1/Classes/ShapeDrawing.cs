using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1.Classes
{
    static class ShapeDrawing
    {
        static private List<MainPoint> Shapes;

        static public void SetPainter(List<MainPoint> list)
        {
            foreach(MainPoint s in list)
            {
                Shapes.Add(s);
            }
        }

        static public void DrawShape(Graphics gr, MainPoint sh)
        {
            
        }
        
    }
}

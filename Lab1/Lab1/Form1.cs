using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Lab1.Draw_Methods;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private class colorClass
        {
            public string nameColor { get; set; }
            public Color color { get; set; }
        }
        
        private class widthClass
        {
            public string nameWidth { get; set; }
            public int width { get; set; }
        }

        private Graphics gr;

        private List<colorClass> colorSource = new List<colorClass>();
        private List<widthClass> widthSource = new List<widthClass>();
        private List<Button> btns = new List<Button>();

        private ShapeController listOfShapes = new ShapeController(); //
        
        public Type currTypeShape;

        public Type currTypePainter;

        private MainPoint shape;

        private ShapePainter painter;

        public Form1()
        {
            InitializeComponent();
        }

        private void SetCoord(ref List<Point> pts)
        {
            pts.Add(new Point(40, 20)); //Line
            pts.Add(new Point(90, 130)); //Line
            pts.Add(new Point(350, 90)); //Triangle
            pts.Add(new Point(350, 20));
            pts.Add(new Point(450, 20)); //Rectangle
            pts.Add(new Point(700, 130));
            pts.Add(new Point(125, 25)); // Ellipse
            pts.Add(new Point(250, 100));
            pts.Add(new Point(400, 300)); //Hexagon
            pts.Add(new Point(500, 300));
            pts.Add(new Point(150, 300)); //Pentagon
            pts.Add(new Point(150, 200));
            pts.Add(new Point(600, 300)); //Star
            pts.Add(new Point(600, 200));
        }

        private void SetBtns()
        {
            btns.Add(btnLine);
            btns.Add(btnTriangle);
            btns.Add(btnRect);
            btns.Add(btnEllipse);
            btns.Add(btnPentagon);
            btns.Add(btnHexagon);
            btns.Add(btnStar);
        }

        private void AddColor()
        {
            colorSource.Add(new colorClass { nameColor = "Черный", color = Color.Black });
            colorSource.Add(new colorClass { nameColor = "Синий", color = Color.Blue });
            colorSource.Add(new colorClass { nameColor = "Красный", color = Color.Red});
            colorSource.Add(new colorClass { nameColor = "Зеленый", color = Color.Green });
            colorSource.Add(new colorClass { nameColor = "Желтый", color = Color.Yellow });
        }

        private void AddWidth()
        {
            widthSource.Add(new widthClass { nameWidth = "1", width = 1 });
            widthSource.Add(new widthClass { nameWidth = "2", width = 2 });
            widthSource.Add(new widthClass { nameWidth = "3", width = 3 });
            widthSource.Add(new widthClass { nameWidth = "4", width = 4 });
        }

        private void FillCB()
        {
            for (int i = 0; i < colorSource.Count; i++)
            {
                boxColor.Items.Add(colorSource[i].nameColor);
            }
            for (int i = 0; i < widthSource.Count; i++)
            {
                boxWidth.Items.Add(widthSource[i].nameWidth);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddColor();
            AddWidth();
            FillCB();
            SetBtns();
            boxColor.SelectedIndex = 0;
            boxWidth.SelectedIndex = 0;
        }

        private void clearWindow_Click(object sender, EventArgs e)
        {
            clrWindow();
            listOfShapes.DelShapes();
        }

        private void clrWindow()
        {
            DrawPanel.Invalidate();
            DrawPanel.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   /*         try
            {
                int i = 0;
                clearWindow_Click(sender, e);
                var control = new ShapeController();//
                gr = DrawPanel.CreateGraphics();
               
                List<Point> pts = new List<Point>();
                SetCoord(ref pts);
                control.AddShape(new Line(pts[i++], pts[i++]));
                control.AddShape(new Triangle(pts[i++], pts[i++]));
                control.AddShape(new Rectangle(pts[i++], pts[i++]));
                control.AddShape(new Ellipse(pts[i++], pts[i++]));
                control.AddShape(new Hexagon(pts[i++], pts[i++]));
                control.AddShape(new Pentagon(pts[i++], pts[i++]));
                control.AddShape(new Star(pts[i++], pts[i++]));          
                control.DrawShapes(gr);             
            }
            catch
            {
                MessageBox.Show("Программа была завершена некорректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void TBx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            gr = DrawPanel.CreateGraphics();
            TBx1.Text = Convert.ToString(e.Location.X);
            TBy1.Text = Convert.ToString(e.Location.Y);   
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                painter = (ShapePainter)Activator.CreateInstance(currTypePainter, false); 
                shape = (MainPoint)Activator.CreateInstance(currTypeShape, false); 
                shape.setCoordSt(e.Location);
                painter.SetPenSettings(colorSource[boxColor.SelectedIndex].color, widthSource[boxWidth.SelectedIndex].width);
                painter.SetStartPoint = shape.GetStartPoint; 
            }
            catch
            {
                MessageBox.Show("Выберите фигуру", "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            gr = DrawPanel.CreateGraphics();
            shape.setCoordF(e.Location);
            painter.SetFinishPoint = shape.GetFinishPoint;//
            painter.DrawShape(gr);//
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            currTypeShape = typeof(Line);
            currTypePainter = typeof(LinePainter);
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            currTypeShape = typeof(Triangle);
            currTypePainter = typeof(TrianglePainter);
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            currTypeShape = typeof(Rectangle);
            currTypePainter = typeof(RectanglePainter);
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            currTypeShape = typeof(Ellipse);
            currTypePainter = typeof(EllipsePainter);
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            currTypeShape = typeof(Pentagon);
            currTypePainter = typeof(PentagonPainter);
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            currTypeShape = typeof(Hexagon);
            currTypePainter = typeof(HexagonPainter);
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            currTypeShape = typeof(Star);
            currTypePainter = typeof(StarPainter);
        }
    }
}

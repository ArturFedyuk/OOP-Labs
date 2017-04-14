namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.clearWindow = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Standart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBy1 = new System.Windows.Forms.TextBox();
            this.TBx1 = new System.Windows.Forms.TextBox();
            this.boxColor = new System.Windows.Forms.ComboBox();
            this.boxWidth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnHexagon = new System.Windows.Forms.Button();
            this.btnPentagon = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawPanel.Location = new System.Drawing.Point(1, 1);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(736, 471);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseDown);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // clearWindow
            // 
            this.clearWindow.BackColor = System.Drawing.SystemColors.Control;
            this.clearWindow.Location = new System.Drawing.Point(11, 108);
            this.clearWindow.Name = "clearWindow";
            this.clearWindow.Size = new System.Drawing.Size(101, 42);
            this.clearWindow.TabIndex = 0;
            this.clearWindow.Text = "Очистить";
            this.clearWindow.UseVisualStyleBackColor = false;
            this.clearWindow.Click += new System.EventHandler(this.clearWindow_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.groupBox2);
            this.MenuPanel.Controls.Add(this.groupBox1);
            this.MenuPanel.Controls.Add(this.Standart);
            this.MenuPanel.Location = new System.Drawing.Point(736, 1);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(242, 471);
            this.MenuPanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearWindow);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TBy1);
            this.groupBox2.Controls.Add(this.TBx1);
            this.groupBox2.Controls.Add(this.boxColor);
            this.groupBox2.Controls.Add(this.boxWidth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 171);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Координата Y";
            // 
            // Standart
            // 
            this.Standart.Location = new System.Drawing.Point(3, 424);
            this.Standart.Name = "Standart";
            this.Standart.Size = new System.Drawing.Size(101, 42);
            this.Standart.TabIndex = 8;
            this.Standart.Text = "Статическая инициализация";
            this.Standart.UseVisualStyleBackColor = true;
            this.Standart.Visible = false;
            this.Standart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Координата Х";
            // 
            // TBy1
            // 
            this.TBy1.Enabled = false;
            this.TBy1.Location = new System.Drawing.Point(9, 82);
            this.TBy1.Name = "TBy1";
            this.TBy1.Size = new System.Drawing.Size(54, 20);
            this.TBy1.TabIndex = 11;
            this.TBy1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBx1_KeyPress);
            // 
            // TBx1
            // 
            this.TBx1.Enabled = false;
            this.TBx1.Location = new System.Drawing.Point(9, 41);
            this.TBx1.MaxLength = 3;
            this.TBx1.Name = "TBx1";
            this.TBx1.Size = new System.Drawing.Size(54, 20);
            this.TBx1.TabIndex = 8;
            this.TBx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBx1_KeyPress);
            // 
            // boxColor
            // 
            this.boxColor.FormattingEnabled = true;
            this.boxColor.Location = new System.Drawing.Point(118, 42);
            this.boxColor.Name = "boxColor";
            this.boxColor.Size = new System.Drawing.Size(97, 21);
            this.boxColor.TabIndex = 3;
            // 
            // boxWidth
            // 
            this.boxWidth.FormattingEnabled = true;
            this.boxWidth.Location = new System.Drawing.Point(118, 81);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(97, 21);
            this.boxWidth.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цвет линии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Толщина линии";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStar);
            this.groupBox1.Controls.Add(this.btnHexagon);
            this.groupBox1.Controls.Add(this.btnPentagon);
            this.groupBox1.Controls.Add(this.btnEllipse);
            this.groupBox1.Controls.Add(this.btnRect);
            this.groupBox1.Controls.Add(this.btnTriangle);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 180);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Геометрическая фигура";
            // 
            // btnStar
            // 
            this.btnStar.Location = new System.Drawing.Point(9, 103);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(103, 22);
            this.btnStar.TabIndex = 6;
            this.btnStar.Text = "Звезда";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnHexagon
            // 
            this.btnHexagon.Location = new System.Drawing.Point(122, 75);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(103, 22);
            this.btnHexagon.TabIndex = 5;
            this.btnHexagon.Text = "Шестиугольник";
            this.btnHexagon.UseVisualStyleBackColor = true;
            this.btnHexagon.Click += new System.EventHandler(this.btnHexagon_Click);
            // 
            // btnPentagon
            // 
            this.btnPentagon.Location = new System.Drawing.Point(9, 75);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(103, 22);
            this.btnPentagon.TabIndex = 4;
            this.btnPentagon.Text = "Пятиугольник";
            this.btnPentagon.UseVisualStyleBackColor = true;
            this.btnPentagon.Click += new System.EventHandler(this.btnPentagon_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(122, 47);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(102, 22);
            this.btnEllipse.TabIndex = 3;
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(9, 47);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(103, 22);
            this.btnRect.TabIndex = 2;
            this.btnRect.Text = "Прямоугольник";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(122, 19);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(103, 22);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.Text = "Треугольник";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(9, 19);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(103, 22);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 471);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.DrawPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "OOP Lab 1, 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button clearWindow;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Standart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnHexagon;
        private System.Windows.Forms.Button btnPentagon;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBy1;
        private System.Windows.Forms.TextBox TBx1;
        private System.Windows.Forms.ComboBox boxColor;
        private System.Windows.Forms.ComboBox boxWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


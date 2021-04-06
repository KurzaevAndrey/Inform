using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurzaev9_16_03_ind
{
    public partial class Form1 : Form
    {
        Point[] points = new Point[50];

        Pen pen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            drawEye(0, 0, g);
            drawEye(400, 0,g);

            g.FillRectangle(Brushes.Brown, new Rectangle(330, 50, 40, 100));
            g.FillRectangle(Brushes.Brown, new Rectangle(150, 200, 400, 50));

        }
        private void drawEye(int x, int y, Graphics g)
        {
            g.DrawLines(pen, points);
            g.DrawEllipse(pen, new Rectangle(x, y, 300, 100));
            //g.DrawEllipse(pen, new Rectangle(300, 80, 100, 100));
            g.FillEllipse(Brushes.Aqua, new Rectangle(x + 100, y, 100, 100));

            g.FillEllipse(Brushes.Black, new Rectangle(x + 120,y + 20, 60, 60));
            g.FillEllipse(Brushes.White, new Rectangle(x + 120,y + 20, 30, 30));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

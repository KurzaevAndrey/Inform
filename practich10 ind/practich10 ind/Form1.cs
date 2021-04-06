using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurzaev10_16_03_ind
{
    public partial class Form1 : Form
    {
        private float x1, y1, x2, y2, r;

        private void Form1_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillEllipse(Brushes.Black, x1, y1, x2, y2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 0;
            x1 = 100;
            y1 = 200;
            x2 = 100;
            y2 = 100;
            r = 100;
        }

        private double a;

        private Pen pen = new Pen(Color.DarkRed, 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 1;

            y1 = y1 - r *(float)Math.Sin(a);
            label1.Text = ((Math.Sin(a))).ToString();
            Invalidate();
        }
    }
}

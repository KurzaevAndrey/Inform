using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurzaev_09_02_2pract
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
    }

    private void button1_Click(object sender, EventArgs e)
    {

      double x = double.Parse(textBox1.Text);
      textBox2.Text += Environment.NewLine + "При х =" + x.ToString();
      double y;
      double tempA = Math.Cos(Math.Sqrt(x + 1));
      double tempB = 2 * Math.Abs(1 - Math.Sqrt(x));
      double tempC = 3 * (1 + Math.Pow(Math.E, x));
      double tempD = Math.Pow(2, x + 1) - 1;// ostanovilsa zdec
      tempC = tempC / tempD;
            tempB = tempB + tempC;
            y = tempA / tempB;

      textBox2.Text += Environment.NewLine + "Результат у = " + y.ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "2";
      textBox2.Text = "Практическая работа N 2 Курзаев А.А.";
      textBox2.Text += Environment.NewLine + "рассчитать значение выражения длинного выражения";

    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double formula(double x)
        {
            return 6 * Math.Pow(x, 7) - 4.5 * Math.Pow(x, 5) + 4 * Math.Pow(x, 2); // формула
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            if (Math.Abs(formula(a) -b)< Math.Pow(10, 3)){
                label3.Visible = true;
                label3.Text = "Точка лежит на прямой";
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Точка не лежит на прямой";
            }
              
        }
    }
}

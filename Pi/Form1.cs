using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(200, 0, 0, 0);
            label2.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isInt;
            if (Int32.TryParse(textBox1.Text, out isInt))
            {
                if (Int32.Parse(textBox1.Text) >= 0 && Int32.Parse(textBox1.Text) <= DisplayPI.PI.Length - 2)
                {
                    label2.ForeColor = Color.FromArgb(120, 255, 255, 255);
                    label2.Text = DisplayPI.ConcatPI(Int32.Parse(textBox1.Text));
                }
                else
                {
                    label2.ForeColor = Color.FromArgb(100, 180, 180, 180);
                    label2.Text = "Число должно быть положительным и меньше 1000.";
                }
            }
            else
            {
                label2.ForeColor = Color.FromArgb(250, 255, 50, 50);
                label2.Text = "Введите число!";
            }
        }
    }
}

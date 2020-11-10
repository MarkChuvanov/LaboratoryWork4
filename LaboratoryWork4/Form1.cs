using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaboratoryWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate1_Click(object sender, EventArgs e)
        {
            if ((Argument.Text == "") && (!double.TryParse(Argument.Text, out _)))
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }
            double x = double.Parse(Argument.Text);
            if ((3 * x + 21) < 0)
            {
                Result1.Text = "Функция не существует!";
            }
            else
            {
                Result1.Text = ((2 * x - 7) / Math.Sqrt(3 * x + 21)).ToString();
            }
        }
        private void Calculate2_Click(object sender, EventArgs e)
        {
            if ((Argument.Text == "") && (!double.TryParse(Argument.Text, out _)))
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }
        }
        private void Calculate3_Click(object sender, EventArgs e)
        {
            if ((Argument.Text == "") && (!double.TryParse(Argument.Text, out _)))
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }
        }
    }
}
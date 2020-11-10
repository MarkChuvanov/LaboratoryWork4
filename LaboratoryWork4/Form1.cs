using System;
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
            double x = double.Parse(Argument.Text);
            if ((x == 1) && (x / (x - 1) < 0))
            {
                Result2.Text = "Функция не существует!";
            }
            else
            {
                Result2.Text = Math.Sqrt(x / (x - 1)).ToString();
            }
        }
        private void Calculate3_Click(object sender, EventArgs e)
        {
            if ((Argument.Text == "") && (!double.TryParse(Argument.Text, out _)))
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }
            double x = double.Parse(Argument.Text);
            if ((x < 0) && (x == 1))
            {
                Result3.Text = "Функция не существует!";
            }
            else
            {
                Result3.Text = ((x + 1) / (x - 1) + Math.Sqrt(x * x)).ToString();
            }
        }
    }
}
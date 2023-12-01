using System;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private double value_hypotenuse = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string input_text = textBox1.Text;

            if (double.TryParse(input_text, out value_hypotenuse) && value_hypotenuse > 0)
            {
                double area_triangle = (value_hypotenuse * value_hypotenuse) / 4;
                textBox2.Text = area_triangle.ToString();
            }
            else
            {
                textBox2.Text = "Invalid value entered";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            value_hypotenuse = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

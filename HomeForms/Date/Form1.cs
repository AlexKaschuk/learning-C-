using System;
using System.Windows.Forms;

namespace Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") {
               DateTime t = new DateTime(Int32.Parse(textBox3.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox1.Text));
                textBox4.Text = t.DayOfWeek.ToString();
            }
        }
    }
}

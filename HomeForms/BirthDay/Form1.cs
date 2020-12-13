using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "") {
                DateTime t = new DateTime(Int16.Parse(textBox3.Text), Int16.Parse(textBox2.Text), Int16.Parse(textBox1.Text));
                monthCalendar1.SetDate(t);
            
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                DateTime t = new DateTime(Int16.Parse(textBox3.Text), Int16.Parse(textBox2.Text), Int16.Parse(textBox1.Text));
                monthCalendar1.SetDate(t);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                DateTime t = new DateTime(Int16.Parse(textBox3.Text), Int16.Parse(textBox2.Text), Int16.Parse(textBox1.Text));
                monthCalendar1.SetDate(t);

            }
        }
    }
}

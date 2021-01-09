using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Microsoft Sans Serif", 9);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Microsoft Sans Serif", 18);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Microsoft Sans Serif", 4);
        }
    }
}

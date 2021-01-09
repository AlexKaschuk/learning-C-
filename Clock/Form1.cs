using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        DateTime date = new DateTime();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Text = "00:00.000";
            numericUpDown5.Value = DateTime.Now.Hour;
            numericUpDown6.Value = DateTime.Now.Minute;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            date = date.AddMilliseconds(1);
            label2.Text = date.ToString("mm:ss.fff");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "00:00.000";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer3.Interval = 1000;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            date = date.AddSeconds(1);
            if (date.Day-1 == (int)numericUpDown1.Value&& date.Hour == (int)numericUpDown2.Value
                && date.Minute==(int)numericUpDown3.Value&&date.Second==(int)numericUpDown4.Value) {
                timer3.Stop();
                MessageBox.Show("Time is out");
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
           
            if (DateTime.Now.Hour == (int)numericUpDown5.Value && DateTime.Now.Minute == (int)numericUpDown6.Value)
            {
                timer4.Stop();
                MessageBox.Show("Time is out");
                button6.Enabled = true;
                button7.Enabled = false;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer4.Start();
            button6.Enabled = false;
            button7.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown5.Value = DateTime.Now.Hour;
            numericUpDown6.Value = DateTime.Now.Minute;
            timer4.Stop();
            button6.Enabled = true;
            button7.Enabled = false;
        }
    }
}

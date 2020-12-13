using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("не вірне значення у першому полі");
            }
            else {
                label2.Text = $"{((int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays).ToString()} днів";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("не вірне значення у першому полі");
            }
            else
            {
                label2.Text = $"{((int)(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays).ToString()} днів";
            }
        }
    }
}

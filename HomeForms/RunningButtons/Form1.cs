using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ми так і гадали");
            Close();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Top -= e.Y;
            button2.Left += e.X;

            if (button2.Top < -10 || button2.Top > 100) {
                button2.Top = 60;
            }
            if (button2.Left < 80 || button2.Left > 250) {
                button2.Left = 120;
            }
        }
    }
    
}

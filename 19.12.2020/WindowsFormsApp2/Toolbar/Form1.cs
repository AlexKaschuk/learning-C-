using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close");
        }
    }
}

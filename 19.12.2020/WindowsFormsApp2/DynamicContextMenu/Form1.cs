using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateMenuStrip();
        }

        private void CreateMenuStrip() {

            ContextMenuStrip menuStrip = new ContextMenuStrip();
            ToolStripItem close = menuStrip.Items.Add("Close");
            ToolStripItem max = menuStrip.Items.Add("maximise");
            ToolStripItem min = menuStrip.Items.Add("minimise");
            ToolStripItem normal = menuStrip.Items.Add("normal");

            this.ContextMenuStrip = menuStrip;


            close.Click += Close_Click;
            max.Click += Max_Click;
            min.Click += Min_Click;
            normal.Click += Normal_Click;
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

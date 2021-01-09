using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateMenu();
        }

        private void CreateMenu()
        {
            MenuStrip menu = new MenuStrip();
            ToolStripMenuItem file = new ToolStripMenuItem("File");
            ToolStripMenuItem edit = new ToolStripMenuItem("Edit");
            ToolStripItem cut  = edit.DropDownItems.Add("cut");
            cut.Click += Cut_Click;       
            menu.Items.Add(file);
            menu.Items.Add(edit);
            this.Controls.Add(menu);

        }

        private void Cut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cut");
        }
    }
}

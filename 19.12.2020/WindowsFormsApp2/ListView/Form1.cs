using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateList();
        }


        private void CreateList()
        {
            listView1.Items.Add("one");
            listView1.Items.Add("two");
            listView1.Items.Add("three");
            listView1.Items.Add("four");
            listView1.Items.Add("five");
            listView1.Items.Add("six");
            listView1.Items.Add("seven");

            listView1.Columns.Add("column1"); 
            listView1.Columns[0].Width = 100;
            listView1.Columns.Add("column2");
            listView1.Columns[1].Width = 150;
            listView1.Columns.Add("column1");
            listView1.Columns[2].Width = 250;

            for (int i = 0; i < listView1.Items.Count; i++) {

                listView1.Items[i].SubItems.Add(i.ToString());
                listView1.Items[i].SubItems.Add((i*10).ToString());
            }   

        }

        private void largerIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}

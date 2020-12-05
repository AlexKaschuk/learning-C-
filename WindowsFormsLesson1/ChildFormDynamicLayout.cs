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
    public partial class ChildFormDynamicLayout : Form
    {
        Random random = new Random();

        List<string> t = new List<string>();
        public ChildFormDynamicLayout()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control item in Matrix.Controls) {
                item.Text = random.Next(0, 100).ToString();
                //item.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            }
        }

        private void ChildFormDynamicLayout_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int columns = (int)Columns.Value;
            int rows = (int)Rows.Value;
            Matrix.Controls.Clear();
            Matrix.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Matrix.ColumnCount = columns;
            Matrix.RowCount = rows;
            Matrix.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Matrix.ColumnStyles.Clear();
            Matrix.RowStyles.Clear();
            for (int i = 0; i < rows; i++) {
                Matrix.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f / rows));
             }
            for (int i = 0; i < columns; i++)
            {
                Matrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f / columns));
            }

            Button bb = null;
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    bb = new Button();
                    Matrix.Controls.Add(bb, j, i);
                    bb.Dock = DockStyle.Fill;
                    bb.Margin = new Padding(5);
                    bb.Padding = new Padding(3);
                    bb.Text = random.Next(0, 100).ToString();
                    t.Add(bb.Text);
                    bb.Click += Bb_Click;
                }
            }
            t.Sort();
            //game();

        }

        private void Bb_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == t[0])
            {
                (sender as Button).BackColor = Color.Red;
                (sender as Button).Enabled = false;
                t.Remove(t[0]);
                if (t.Count == 0) { MessageBox.Show("you win"); }
            }
            else {
                MessageBox.Show("you lost");
                t.Clear();
                timer1.Stop();
            }





        }
    }
}

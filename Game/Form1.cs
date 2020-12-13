using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<int> t = new List<int>();
       
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
        }
 
        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control item in Matrix.Controls)
            {
                item.Text = random.Next(0, 100).ToString();
                
            }
        }


        private void CreateMatrix() {
            int columns = (int)Columns.Value;
            int rows = (int)Rows.Value;
            Matrix.Controls.Clear();
            Matrix.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Matrix.ColumnCount = columns;
            Matrix.RowCount = rows;
            Matrix.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Matrix.ColumnStyles.Clear();
            Matrix.RowStyles.Clear();
            for (int i = 0; i < rows; i++)
            {
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
                    t.Add(Int32.Parse(bb.Text));
                    bb.Click += Bb_Click;
                }
            }
            t.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMatrix();
        }

        private void Bb_Click(object sender, EventArgs e)
        {
            MessageBoxButtons b = MessageBoxButtons.YesNo;
            if (Int32.Parse((sender as Button).Text) == t[0])
            {
               
                (sender as Button).BackColor = Color.Red;
                (sender as Button).Enabled = false;
                t.Remove(t[0]);
                 if (t.Count == 0) { 
                    if (MessageBox.Show( "do you want to play again", "you win", b) == DialogResult.Yes)
                    {
                        CreateMatrix();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            else
            {
                t.Clear();
                timer1.Stop();
                if (MessageBox.Show("do you want to play again", "you lost", b)== DialogResult.Yes)
                {
                    CreateMatrix();
                }
                else
                {
                    Close();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool move = true;
        bool rect = false;
        bool elipse = false;
        Pen pen = new Pen(Color.Black, 5);
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            move = true;
            rect = false;
            elipse = false;
            pen.Color = Color.Black;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                pen.Color = colorDialog1.Color;
             }
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && move && x != -1 && y != -1 && rect == false&&elipse==false)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && x != -1 && y != -1 && rect == true)
            {
                g.DrawRectangle(pen, new Rectangle(e.X > x ? x : e.X, e.Y > y ? y : e.Y, e.X > x ? e.X - x : x - e.X, e.Y > y ? e.Y - y : y - e.Y));
            }
            else if (e.Button == MouseButtons.Left && x != -1 && y != -1 && elipse == true) {
                g.DrawEllipse(pen, new Rectangle(e.X > x ? x : e.X, e.Y > y ? y : e.Y, e.X > x ? e.X - x : x - e.X, e.Y > y ? e.Y - y : y - e.Y));
            }
            x = -1;
            y = -1;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            pen.Color = panel1.BackColor;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rect = true;

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            elipse = true;
            rect = false;
        }
    }
}

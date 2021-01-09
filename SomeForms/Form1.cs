using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SomeForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Show();
            Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Aqua, 50, 100, 200, 100);


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Pen p = new Pen(Color.Red, 3);
            //p.DashStyle = DashStyle.Dot;
            //g.DrawEllipse(p, 50,100,200,100);
            //g.FillEllipse(Brushes.Aqua, 50, 100, 200, 100);

            //Rectangle r1 = new Rectangle(20, 20, 120, 60);
            //SolidBrush brush = new SolidBrush(Color.Orange);
            //g.FillRectangle(brush, r1);

            //Rectangle r2 = new Rectangle(20, 120, 120, 60);
            //LinearGradientBrush l = new LinearGradientBrush(r2, Color.Orange, Color.Blue, LinearGradientMode.Vertical);
            ////g.FillRectangle( l, r2);

            ////Rectangle r3 = new Rectangle(20, 220, 120, 60);
            ////HatchBrush h = new HatchBrush(HatchStyle.Wave, Color.Blue, Color.Red);
            ////g.FillRectangle(h, r3);


            ////TextureBrush t = new TextureBrush(new Bitmap(@"path"));

            //g.DrawString("Hello World", new Font("Verdana", 35), l, 50, 20);




        }
    }
}

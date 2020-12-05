using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        class MyButton : Button
        {
            public MyButton() : base()
            {
                 SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private Point From, To;
        private List<Button> btn = new List<Button>();
       private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                To = e.Location;
                Form1_Paint(From, To);
                Invalidate();
            }
           
        }

        private void Form1_Paint(Point From, Point To)
        {
            if (Math.Abs(From.X - To.X)>10&& Math.Abs(From.Y - To.Y) > 10)
            {

                MyButton b = new MyButton();
                b.Location = To.X > From.X && To.Y > From.Y ? From :
                    To.X < From.X && To.Y < From.Y ? To : To.X < From.X && To.Y > From.Y ?
                    new Point(To.X, From.Y) : new Point(From.X, To.Y);
                b.Text = (btn.Count + 1).ToString();
                b.Size = new Size(Math.Abs(From.X - To.X), Math.Abs(From.Y - To.Y));
                b.Name = b.Text;
                b.MouseClick += B_MouseClick;
                //b.MouseHover += B_MouseHover;
               // b.MouseMove += B_MouseHover;
                b.DoubleClick += B_DoubleClick;
                b.Parent = this;
               
                Controls.Add(b);
              
                btn.Add(b);
            }
        }

        private void B_DoubleClick(object sender, EventArgs e)
        {
            (sender as MyButton).Dispose();
        }

        private void B_MouseHover(object sender, EventArgs e)
        {
 
            if (sender.GetType().Name == "Button")
            {
              Button button1 = sender as Button;

              int x = button1.Location.X;
              int y = button1.Location.Y;
              Random n = new Random();
              int k = n.Next(4);
              switch (k)
                {

                    case 1:
                        button1.Location = new Point(x + button1.Size.Width+20, y + button1.Size.Height);
                        break;
                    case 2:
                        button1.Location = new Point(x - button1.Size.Width+20, y - button1.Size.Height);
                        break;
                    case 3:
                        button1.Location = new Point(x + button1.Size.Width+20, y - button1.Size.Height);
                        break;
                    case 4:
                        button1.Location = new Point(x - button1.Size.Width+20, y + button1.Size.Height);
                        break;
                }
                if (button1.Left < 50)
                { button1.Left = 50; }
                if ((button1.Left + button1.Width) > this.ClientSize.Width)
                { button1.Left = this.ClientSize.Width - button1.Width+20; }
                if (button1.Top < 50)
                { button1.Top = 50; }
                if ((button1.Top + button1.Height) > this.ClientSize.Height)
                { button1.Top = this.ClientSize.Height - button1.Height+20; }

            }

        }


        private void B_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
            {
                Button bt = btn.Find(x => x.Text == (sender as Button).Text);
                Text = $"Location {bt.Location} : Area {bt.Size.Width * bt.Size.Height}px";
            }

        }

     

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                From = e.Location;
            }
        }


    }
}

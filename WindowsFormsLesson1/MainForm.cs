using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           

            //Button b = new Button();
            //Text = "My text";
            //BackColor = Color.FromArgb(110, 110, 150);
            //Size = new Size(450, 450);
            //StartPosition = FormStartPosition.Manual;
            //Location = new Point(400, 70);
            //b.Text = "OK";
            //b.AutoSize = true;
           // b.Name = "ButtonOK";
           // b.Location = new Point(150, 200);
            //// this.autoSizeMode = AutoSizeMode.GrowAndShrink;
            ////AutoSize = true;
           // b.Parent = this;
            //Controls.Add(b);
           // b.MouseClick += B_MouseClick;
            ////Controls["ButtonOK"].Click += ButtonOK_Click;
            FormClosing += MainForm_FormClosing;
            //FormClosed += MainForm_FormClosed;

        }

        //private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    MessageBox.Show("Closed");

        //}

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if( MessageBox.Show("do you want to close window", "form closing ", MessageBoxButtons.YesNo )==DialogResult.No)
                e.Cancel = true;
            
        }

        //private void B_MouseClick(object sender, MouseEventArgs e)=>
        //       Text = $"{e.Button}:{e.X} : {e.Y}";

        //private void ButtonOK_Click(object sender, EventArgs e)=>
        //    Close();
 
        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //ChildFormDock childForm = new ChildFormDock();
            //childForm.Owner = this;
            //childForm.ShowDialog();

            ChildFormDynamicLayout childForm = new ChildFormDynamicLayout();
            childForm.Owner = this;
            childForm.ShowDialog();
        }
    }
}

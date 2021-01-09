using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               var Path = openFileDialog1.FileName;
                textBox1.Text = "";
                using (StreamReader sr = new StreamReader(Path)) {
                    textBox1.Text += sr.ReadToEnd();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var Path = openFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    sw.WriteLine(textBox1.Text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                var Path = folderBrowserDialog1.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(Path);
                ShowDirectories(di);
            }
        }

        private void ShowDirectories(DirectoryInfo di) {
            foreach (var i in di.GetFiles())
            {
                listBox1.Items.Add(i.Name);
            }
            var dir = di.GetDirectories();
            if (dir.Length > 0)
            {
                foreach (var i in dir) {
                    listBox1.Items.Add(i.Name);
                    DirectoryInfo di1 = new DirectoryInfo(i.FullName);
                    ShowDirectories(di1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
    }
}

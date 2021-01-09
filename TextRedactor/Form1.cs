using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRedactor
{
    public partial class Form1 : Form
    {

        string Path;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = openFileDialog1.FileName;
                richTextBox1.Text = "";
                using (StreamReader sr = new StreamReader(Path))
                {
                    richTextBox1.Text += sr.ReadToEnd();
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Find form = new Find();
            form.Owner = this;
            form.Show(richTextBox1);

            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Path != "")
            {
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    sw.WriteLine(richTextBox1.Text);
                }
            }
            else {
                toolStripButton3_Click(sender, e);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(richTextBox1.Text);
                }
                Path = saveFileDialog1.FileName;
            }
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont =  new Font(toolStripComboBox1.Text, (float)numericUpDown1.Value);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(richTextBox1.SelectedText);
            richTextBox1.SelectedText = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Text);
            richTextBox1.Paste(myFormat);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRedactor
{
    public partial class Find : Form
    {
        RichTextBox box;
        public Find()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int len = box.TextLength;
                int index = 0;
                int lastIndex = box.Text.LastIndexOf(textBox1.Text);
                while (index < lastIndex)
                {
                    box.Find(textBox1.Text, index, len, RichTextBoxFinds.None);
                    box.SelectionBackColor = Color.Yellow;
                    index = box.Text.IndexOf(textBox1.Text, index) + 1;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Show(RichTextBox box) {
            this.box = box;
            this.Show();
        }

    }
}

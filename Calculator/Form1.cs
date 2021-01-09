using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string tmp2 = "";
        double tmp=0;
        bool acted = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") { label1.Text = $"{int.Parse(label1.Text)*-1}"; }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Count(sender);
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text.Length > 6) { label1.Font = new Font("Microsoft Sans Serif", 19); }
            else { label1.Font = new Font("Microsoft Sans Serif", 35); }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Actions(sender);
        }

        private void Count(object sender) {
            if (label1.Text == "0")
                label1.Text = (sender as Button).Text.ToString();
            else if (acted == true) 
            {
                label1.Text = "";
                acted = false;
                label1.Text += (sender as Button).Text.ToString();
            }
            else
            {
                 label1.Text += (sender as Button).Text.ToString();
            }
        }

        private void Actions(object sender)
        {           
            if ((sender as Button).Text != "="&& (sender as Button).Text != "%")
            {
                tmp = double.Parse(label1.Text);
                tmp2 = (sender as Button).Text;
                acted = true;
                switch (tmp2)
                {
                    case "Sqrt(x)":
                        {
                            label1.Text = $"{Math.Sqrt(tmp)}";
                            acted = true;
                            break;
                        }
                    case "x2":
                        {
                            label1.Text = $"{tmp * tmp}";
                            acted = true;
                            break;
                        }
                    case "1/x":
                        {
                            label1.Text = $"{1 / tmp}";
                            acted = true;
                            break;
                        }
                }
            }
            else if ((sender as Button).Text == "=")
            {
                switch (tmp2)
                {
                    case "+":
                        {
                            label1.Text = $"{tmp + double.Parse(label1.Text)}";
                            acted = true;
                            break;
                        }
                    case "-":
                        {
                            label1.Text = $"{tmp - double.Parse(label1.Text)}";
                            acted = true;
                            break;
                        }
                    case "x":
                        {
                            label1.Text = $"{tmp * double.Parse(label1.Text)}";
                            acted = true;
                            break;
                        }
                    case "'/.":
                        {

                            label1.Text = $"{tmp / double.Parse(label1.Text)}";
                            acted = true;
                            break;
                        }
                    default:
                        break;
                }
            }
            else if ((sender as Button).Text == "%")
            {
                label1.Text = $"{tmp/100* double.Parse(label1.Text)}";
                acted = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0" && label1.Text.Length > 1)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);

            }
            else { label1.Text = "0"; }
        }

        private void button23_Click(object sender, EventArgs e)
        {
                 label1.Text += ","; 
         
        }
    }
}

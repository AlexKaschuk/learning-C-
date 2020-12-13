using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dog_CheckedChanged(object sender, EventArgs e)
        {
            QtyDog.Enabled = QtyDog.Enabled != true;
            if (QtyDog.Enabled == false) {
                double sum = double.Parse(PriseCafe.Text) - double.Parse(PriseDog.Text) * int.Parse(QtyDog.Text);
                PriseCafe.Text = $"{sum}";
                QtyDog.Text = "0"; }
        }

        private void Coca_CheckedChanged(object sender, EventArgs e)
        {
            QtyCoca.Enabled = QtyCoca.Enabled != true;
            if (QtyCoca.Enabled == false) {
                double sum = double.Parse(PriseCafe.Text) - double.Parse(PriseCoca.Text) * int.Parse(QtyCoca.Text);
                PriseCafe.Text = $"{sum}";
                QtyCoca.Text = "0"; }
        }
        private void Fry_CheckedChanged(object sender, EventArgs e)
        {
            QtyFry.Enabled = QtyFry.Enabled != true;
            if (QtyFry.Enabled == false) {
                double sum = double.Parse(PriseCafe.Text) - double.Parse(PriseFry.Text) * int.Parse(QtyFry.Text);
                PriseCafe.Text = $"{sum}"; 
                QtyFry.Text = "0"; }
        }
        private void Burger_CheckedChanged(object sender, EventArgs e)
        {
            QtyBurger.Enabled = QtyBurger.Enabled != true;
            if (QtyBurger.Enabled == false) {
                double sum = double.Parse(PriseCafe.Text) - double.Parse(PriseBurger.Text) * int.Parse(QtyBurger.Text);
                PriseCafe.Text = $"{sum}";
                QtyBurger.Text = "0"; }
        }

        private void QtyDog_TextChanged(object sender, EventArgs e)
        {
            if (QtyDog.Text != "")
            {
                double sum = double.Parse(PriseDog.Text) * int.Parse(QtyDog.Text) + double.Parse(PriseCafe.Text);
                PriseCafe.Text = $"{sum}";
            }
         }

        private void QtyBurger_TextChanged(object sender, EventArgs e)
        {
            if (QtyBurger.Text != "")
            {
                double sum = int.Parse(QtyBurger.Text) * double.Parse(PriseBurger.Text) + double.Parse(PriseCafe.Text);
                PriseCafe.Text = $"{sum}";

            }
        }

        private void QtyFry_TextChanged(object sender, EventArgs e)
        {
            if (QtyFry.Text != "")
            {
                double sum = int.Parse(QtyFry.Text) * double.Parse(PriseFry.Text) + double.Parse(PriseCafe.Text);
                PriseCafe.Text = $"{sum}";

            }
        }

        private void QtyCoca_TextChanged(object sender, EventArgs e)
        {
            if (QtyCoca.Text != "")
            {
                double sum = int.Parse(QtyCoca.Text) * double.Parse(PriseCoca.Text) + double.Parse(PriseCafe.Text);
                PriseCafe.Text = $"{sum}";

            }

        }

        private void OilName_SelectedValueChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).Text)
            {
                case "А-76":
                    {
                        PriseOil.Text = "10,25";
                        break;
                    }
                case "А-80":
                    {
                        PriseOil.Text = "15,30";
                        break;
                    }
                case "А-92":
                    {
                        PriseOil.Text = "19,10";
                        break;
                    }
                case "А-95":
                    {
                        PriseOil.Text = "22,30";
                        break;
                    }
                case "А-98":
                    {
                        PriseOil.Text = "25,20";
                        break;
                    }
                case "ДП":
                    {
                        PriseOil.Text = "19,10";
                        break;
                    }
                case "Газ":
                    {
                        PriseOil.Text = "12,10";
                        break;
                    }

                default:
                    {
                        PriseOil.Text = "10,25";
                        break;
                    }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            QtyOil.Enabled = QtyOil.Enabled != true;
            if (QtyOil.Enabled == false) {
                QtyOil.Text = "";
                PriseForAllOil.Text = "0,00";
            }  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PriseForQtyOil.Enabled = PriseForQtyOil.Enabled != true;
            if (PriseForQtyOil.Enabled == false)
            {
                PriseForQtyOil.Text = "";
                PriseForAllOil.Text = "0,00";
            }
        }

        private void QtyOil_TextChanged(object sender, EventArgs e)
        {
            if (QtyOil.Text != "")
            {
                double sum = double.Parse(PriseOil.Text) * double.Parse((sender as TextBox).Text);
                PriseForAllOil.Text = $"{sum}";
            }
        }

        private void PriseForQtyOil_TextChanged(object sender, EventArgs e)
        {
            PriseForAllOil.Text = (sender as TextBox).Text;
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(PriseForAllOil.Text) + double.Parse(PriseCafe.Text);
            AllPriseCount.Text = $"{sum}";
        }
    }
}

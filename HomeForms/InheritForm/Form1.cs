using System;
using System.IO;
using System.Windows.Forms;

namespace InheritForm
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                comboBox1.Text != "" && comboBox2.Text != "" && comboBox2.Text != "") {
                try
                {
                    Employee emp = new Employee(textBox1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text,
                        int.Parse(textBox2.Text), int.Parse(textBox3.Text));

                    
                    using (StreamWriter sw = new StreamWriter("employee.txt", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(emp);
                    }
                    MessageBox.Show("saved");

                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                
                }
            }
            else {

                MessageBox.Show("enter all parameters");
            }

        }
    }



    public class Employee { 
    public string Surname { get; set; }
    public string Position { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int Bilding { get; set; }
    public int Sallary { get; set; }

        public Employee()
        {

        }
        public Employee(string Surname, string Position, string City, string Street, int Bilding, int Sallary)
        {
            this.Surname = Surname;
            this.Position = Position;
            this.City = City;
            this.Street = Street;
            this.Bilding = Bilding;
            this.Sallary = Sallary;
        }
        public override string ToString()
        {
            return $"Surname {Surname}, Position {Position}, City {City}, Street {Street}, Bilding {Bilding}, Sallary {Sallary}";
        }

    }
}

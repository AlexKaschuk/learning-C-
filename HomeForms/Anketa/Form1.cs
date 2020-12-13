using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Anketa
{
    [Serializable]
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                Person p = new Person(textBox2.Text, textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, dateTimePicker1.Value);
                XmlSerializer formatter = new XmlSerializer(typeof(Person));
                using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, p);
                    MessageBox.Show("data was saved");
                }
            }
        }
    }

    public class Person { 
    public string Name { get; set; }
    public string Surname { get; set; }
    public string FatherName { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime bDay { get; set; }

        public Person() { }
        public Person(string Name, string Surname, string FatherName, string Country, string City, string PhoneNumber, DateTime bDay)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.FatherName = FatherName;
            this.Country = Country;
            this.City = City;
            this.PhoneNumber = PhoneNumber;
            this.bDay = bDay;
        }
    
    }
}

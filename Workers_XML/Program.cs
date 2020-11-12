using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_XML
{
    class Program
    {
        static void Main(string[] args)
        {

            Organization my = new Organization();
            my.AddWorkersRange(new Worker(new Person("Alex", "Kashchuk", "0999999997"),  "head"), 
                new Worker(new Person("Alex", "Qwerty", "0999999998"), "PM"), new Worker(new Person("Alex", "Doom", "0999999999"),  "DataLead"));
            my.SaveData("organization.xml");
            my.LoadData("organization.xml", "organization.xsd");
            my.AddWorker(new Worker(new Person("Alex", "Kashchuk", "0999999997"),  "head"));
            my.Show();

           Console.WriteLine( my.FindWorker(1000001).ToString());

            my.SetNewPhoneNumber(1000001);
            my.SetNewPosition(1000001);
            //my.RemoveWorker("Alex", "Doom");
            my.Show();
            my.SaveData("organization.xml");

        }
    }
}

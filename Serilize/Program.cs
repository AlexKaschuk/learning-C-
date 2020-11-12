using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using System.Net;



namespace StructPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            BookShop books = new BookShop();
            books.AddBooks(new Book { Id = 123, Autor = "Perumov11", Genre = Genre.Programing, Name = "SomeName", Price = 12345 }, new Book { Id = 1234, Autor = "Perumov2", Genre = Genre.Design, Name = "SomeMyName", Price = 123456 },
                new Book { Id = 1235, Autor = "Perumov1", Genre = Genre.Programing, Name = "SomeAnyName", Price = 123457 }, new Book { Id = 1236, Autor = "Perumov4", Genre = Genre.Design, Name = "SomeName2", Price = 123458 });
            //books.ShowBooks();
            //Console.WriteLine();


            {
                //BinaryFormatter bf = new BinaryFormatter();
                //using (Stream sr = new FileStream("books.bin", FileMode.Create, FileAccess.Write)) {
                //    bf.Serialize(sr, books);
                //}

                //books = null;
                //using (Stream sr = new FileStream("books.bin", FileMode.Open, FileAccess.Read)) {
                //    books = bf.Deserialize(sr) as BookShop;
                //}

                //books.ShowBooks();

                //BookShop bc = books.Clone() as BookShop;

                //Console.WriteLine();
                //bc.ShowBooks();

                //Console.WriteLine(bc.Equals(books));
            } //binary
            {
                //XmlSerializer xml = new XmlSerializer(typeof(BookShop));
                //using (Stream sr = new FileStream("books.xml", FileMode.Create, FileAccess.Write)) {
                //    xml.Serialize(sr, books);
                //}
                //books = null;
                //using (Stream sr = new FileStream("books.xml", FileMode.Open, FileAccess.Read))
                //{
                //    books = xml.Deserialize(sr) as BookShop;
                //}

                //books.ShowBooks();


                //List<currency> curs = new List<currency>();
                //WebClient wb = new WebClient();
                //XmlSerializer sss = new XmlSerializer(typeof(List<currency>), new XmlRootAttribute("exchange"));
                //using (Stream sr = wb.OpenRead(@"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange")) {
                //    curs = sss.Deserialize(sr) as List<currency>;
                //}


                //foreach (currency item in curs) {
                //    Console.WriteLine($"{item.r030}: {item.txt} - {item.cc}- {item.rate}");

                //}

            }//xmlFile


            int i;
            do { Console.WriteLine(i); } while (--i > 0);




        }
    }
}

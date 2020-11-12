using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StructPattern
{
    [Serializable]
    [XmlRoot("booksCollection")]
    
    public class BookShop: IEnumerable<Book>, ICloneable
    {
        //[XmlArrayItem("Product", typeof(Book))]
        public List<Book> li = new List<Book>();
        public void Add(Book book) =>
           li.Add(book);
        public void AddBooks(params Book[] books) =>
            li.AddRange(books);
        public void ShowBooks()
        {
            foreach (Book item in li)
            {
                Printer.Print(item, Console.Out);
            }
        }

        public object Clone()
        {
            BookShop cloneBS = null;
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream sr = new MemoryStream())
            {
                bf.Serialize(sr, this);
                sr.Position = 0;
                cloneBS = bf.Deserialize(sr) as BookShop;
            }
            return cloneBS;
        }

        public IEnumerator<Book> GetEnumerator() => li.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}

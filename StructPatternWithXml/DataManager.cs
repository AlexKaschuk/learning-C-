using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace StructPattern
{
    public class DataManager
    {
        public BookShop BookShop { get; set; } = new BookShop();

        public void LoadData(string path, string SchemaPath) {
            XmlReaderSettings set = new XmlReaderSettings { IgnoreWhitespace = true, CloseInput = true, IgnoreComments = true };
            Book currentBook = null;
            if (Validation(path, SchemaPath))
            {
                using (XmlReader reader = XmlReader.Create(path, set))
                {
                    reader.MoveToContent();
                    while (reader.Read() && reader.NodeType == XmlNodeType.Element && reader.Name == "Book")
                    {
                        currentBook = new Book();
                        reader.Read();
                        currentBook.Id = reader.ReadElementContentAsInt("Id", "");
                        currentBook.Name = reader.ReadElementContentAsString("Name", "");
                        currentBook.Autor = reader.ReadElementContentAsString("Autor", "");
                        currentBook.Price = reader.ReadElementContentAsDecimal("Price", "");
                        currentBook.Genre = (Genre)Enum.Parse(typeof(Genre), reader.ReadElementContentAsString("Genre", ""));
                        BookShop.Add(currentBook);
                    }
                }
            }
            else {
                Console.WriteLine("not valid document");
            }
        }

        public void Show() {
            foreach (Book item in BookShop) {
                Console.WriteLine(item.ToString());
            }
        
        }

        private bool Validation(string path, string SchemaPath) {
            XmlReaderSettings set = new XmlReaderSettings(); 
            set.ValidationType = ValidationType.Schema;
            set.Schemas.Add("", SchemaPath);
            using (XmlReader reader = XmlReader.Create(path, set)) {
                try
                {
                    while (reader.Read());
                }
                catch (XmlSchemaValidationException e) {
                    Console.WriteLine(e.Message);
                    return false; 
                }
             }
            return true;
        }


        public void SaveData(string path) {
            using (XmlWriter wr = XmlWriter.Create(path, new XmlWriterSettings { Indent = true })) {
                wr.WriteStartDocument();
                wr.WriteStartElement("booksCollection");
                foreach (Book item in BookShop) {
                    wr.WriteStartElement("Book");
                    wr.WriteElementString("Id", item.Id.ToString());
                    wr.WriteElementString("Name", item.Name);
                    wr.WriteElementString("Autor", item.Autor);
                    wr.WriteElementString("Price", item.Price.ToString("F2", new CultureInfo("en-US")));
                    wr.WriteElementString("Genre", item.Genre.ToString());
                    wr.WriteEndElement();
                }
                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }



    }
}

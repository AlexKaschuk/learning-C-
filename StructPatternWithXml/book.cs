using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace StructPattern
{
    public enum Genre { Programing, Design };


    [UpperCase(true)]
    [Serializable]

    public class Book: IXmlSerializable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Autor { get; set; }

        public decimal Price { get; set; }

        public Genre Genre { get; set; }

        public override string ToString() => $"{Id}\t{Name}\t{Autor}\t{Price:F2}\t{Genre}";

        public XmlSchema GetSchema()=> null;
        
        public void ReadXml(XmlReader reader)
        {
            reader.Read();
            Id = reader.ReadElementContentAsInt("Id", "");
            Name = reader.ReadElementContentAsString("Name", "");
            Autor = reader.ReadElementContentAsString("Autor", "");
            Price = reader.ReadElementContentAsDecimal("Price", "");
            Genre = (Genre)Enum.Parse(typeof(Genre), reader.ReadElementContentAsString("Genre", ""));
            reader.Read();
            
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Id", Id.ToString());
            writer.WriteElementString("Name", Name);
            writer.WriteElementString("Autor", Autor);
            writer.WriteElementString("Price", Price.ToString("F2", new CultureInfo("en-US")));
            writer.WriteElementString("Genre", Genre.ToString());

        }
    }
}

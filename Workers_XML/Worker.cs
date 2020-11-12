using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workers_XML
{
    public class Worker:Person
    {
        public int Id { get; protected set; }
        public string Position { get; set; }
        private static int idCounter = 1000001;

        public Worker() : base() { Id = idCounter; idCounter++; }

        public Worker(Person n, string pos) : base(n.Name, n.Surname, n.PhoneNumber) { Position = pos; Id = idCounter; idCounter++; }
       
        public override string ToString() => $"id: {Id}, " + base.ToString() + $" position: {Position}";

        public void ReadXml(XmlReader reader)
        {
            reader.Read();
            Id = reader.ReadElementContentAsInt("Id", "");
            Name = reader.ReadElementContentAsString("Name", "");
            Surname = reader.ReadElementContentAsString("Surname", "");
            PhoneNumber = reader.ReadElementContentAsString("PhoneNumber", "");
            Position = reader.ReadElementContentAsString("Position", "");
         }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Id", Id.ToString());
            writer.WriteElementString("Name", Name);
            writer.WriteElementString("Surname", Surname);
            writer.WriteElementString("PhoneNumber", PhoneNumber);
            writer.WriteElementString("Position", Position);
        }




    }
}

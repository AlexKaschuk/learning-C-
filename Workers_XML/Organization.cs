using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Workers_XML
{
    public class Organization : IEnumerable<Worker>
    {
        public List<Worker> Workerlist = new List<Worker>();

        public void AddWorker(Worker n) { 
            if(!Workerlist.Exists(x => x.Name == n.Name&&x.Surname==n.Surname&&x.PhoneNumber==n.PhoneNumber)) {
                Workerlist.Add(n); 
            } 
        }
        public void AddWorkersRange(params Worker[] n) {
            foreach (Worker item in n) {
                AddWorker(item);//щоб не могло додати двічі одного і того ж працівника
            }

        }
        private bool Validation(string path, string SchemaPath)
        {
            XmlReaderSettings set = new XmlReaderSettings();
            set.ValidationType = ValidationType.Schema;
            set.Schemas.Add("", SchemaPath);
            using (XmlReader reader = XmlReader.Create(path, set))
            {
                try
                {
                    while (reader.Read()) ;
                }
                catch (XmlSchemaValidationException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            return true;
        }

        public void SaveData(string path)
        {
            using (XmlWriter wr = XmlWriter.Create(path, new XmlWriterSettings { Indent = true }))
            {
                wr.WriteStartDocument();
                wr.WriteStartElement("Workerlist");
                foreach (Worker item in Workerlist)
                {
                    wr.WriteStartElement("Worker");
                    item.WriteXml(wr);
                    wr.WriteEndElement();
                }
                wr.WriteEndElement();
                wr.WriteEndDocument();
            }
        }

        public void LoadData(string path, string SchemaPath)
        {
            XmlReaderSettings set = new XmlReaderSettings { IgnoreWhitespace = true, CloseInput = true, IgnoreComments = true };
            Worker currentWorker = null;
            if (Validation(path, SchemaPath))
            {
                Workerlist.Clear();
                using (XmlReader reader = XmlReader.Create(path, set))
                {
                    reader.MoveToContent();
                    while (reader.Read() && reader.NodeType == XmlNodeType.Element && reader.Name == "Worker")
                    {
                        currentWorker = new Worker();
                        currentWorker.ReadXml(reader);
                        Workerlist.Add(currentWorker);
                    }
                }
            }
            else
            {
                Console.WriteLine("not valid document");
            }
        }

        public void Show()
        {
            Console.WriteLine(Workerlist.Count);
            foreach (Worker item in Workerlist)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public Worker FindWorker(string firstName, string lastname) =>
            Workerlist.Find(x => x.Name == firstName && x.Surname == lastname);

        public Worker FindWorker(int id) =>
            Workerlist.Find(x => x.Id == id);
        public void SetNewPhoneNumber(string firstName, string lastname)
        {
            Console.WriteLine("enter new phonenumber");
            FindWorker(firstName, lastname).PhoneNumber = Console.ReadLine();
        }
        public void SetNewPhoneNumber(int id)
        {
            Console.WriteLine("enter new phonenumber");
            FindWorker(id).PhoneNumber = Console.ReadLine();
        }

        public void SetNewPosition(string firstName, string lastname)
        {
            Console.WriteLine("enter new position");
            FindWorker(firstName, lastname).Position = Console.ReadLine();
        }
        public void SetNewPosition(int id)
        {
            Console.WriteLine("enter new position");
            FindWorker(id).Position = Console.ReadLine(); ;
        }

        public void RemoveWorker(string firstName, string lastname) =>
            Workerlist.Remove(FindWorker(firstName, lastname));

        public void RemoveWorker(int id) =>
            Workerlist.Remove(FindWorker(id));

        public IEnumerator<Worker> GetEnumerator() => Workerlist.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}

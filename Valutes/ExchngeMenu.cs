using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.IO;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;

namespace Valutes
{
    public class ExchngeMenu
    {
        private List<currency> valutes = new List<currency>();

        private List<string> ExchangeHistory = new List<string>();

        private string Address = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date=";

        private static int IdOperation { get; set; } = 1;//щоб зберігались повторні операціїї купівлі-продажу валюти, оскільки стрічки можуть бути ідентичними
        public ExchngeMenu() {
            load();
        }

        public void CursesAtDate(int year, int month, int day)
        {
            WebClient wb = new WebClient();
            XmlSerializer curses = new XmlSerializer(typeof(List<currency>), new XmlRootAttribute("exchange"));
            using (Stream stream = wb.OpenRead(Address + year.ToString()+ month.ToString()+ day.ToString()))
            {
                valutes = curses.Deserialize(stream) as List<currency>;
            }
            SaveFile(new DateTime(year, month, day));
        }

        public void CursesToday()=>        
            CursesAtDate(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        
        public void ShowCurses() {
            foreach (currency item in valutes) {
                Console.WriteLine($"{item.exchangedate}: {item.r030} {item.cc} {item.txt} : {item.rate}");             
            }
        }

        private void SaveFile(DateTime n) {

            XmlSerializer xml = new XmlSerializer(typeof(List<currency>));
            List<currency> temp = new List<currency>();// це для оновлення по датах, щоб не перезаписувало якщо дата старіша за записане у файлі
            if (File.Exists("Currency.xml"))
            {
                using (Stream sr = new FileStream("Currency.xml", FileMode.Open, FileAccess.Read))
                {
                    temp = xml.Deserialize(sr) as List<currency>;
                }
            } 
            if (!File.Exists("Currency.xml") || n > new DateTime(Convert.ToInt32(temp[0].exchangedate.Split('.')[2]), Convert.ToInt32(temp[0].exchangedate.Split('.')[1]), Convert.ToInt32(temp[0].exchangedate.Split('.')[0])))
            { 
                using (Stream sr = new FileStream("Currency.xml", FileMode.Create, FileAccess.Write))
                {
                    xml.Serialize(sr, valutes);
                } 
            }

        }

        public void BuyСurrency(int grn, string CC)
        {
            string tmp = $"{IdOperation} {grn} UAH you bought {grn / valutes.Find(e => e.cc == CC)?.rate:F2} {valutes.Find(e => e.cc == CC).cc} ";
            Console.WriteLine(tmp);
            IdOperation++;
            if (!ExchangeHistory.Exists(e=>e==tmp)) ExchangeHistory.Add(tmp);
            saveHistory(tmp);
        }

        public void SellСurrency(int Cuur, string CC)
        {
            string tmp = $"{IdOperation} {Cuur} {CC} you bought {Cuur * valutes.Find(e => e.cc == CC)?.rate:F2} UAH";
            Console.WriteLine(tmp);
            IdOperation++;
            if (!ExchangeHistory.Exists(e => e == tmp)) ExchangeHistory.Add(tmp);
            saveHistory(tmp);
        }

        private void saveHistory(string exchange) {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream sr = new FileStream("history.bin",FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(sr, ExchangeHistory);
            }
            
        }

        private void load() {
            CursesToday();
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream sr = new FileStream("history.bin", FileMode.Open, FileAccess.Read))
            {
                if (sr.Length != 0)
                   ExchangeHistory = bf.Deserialize(sr) as List<string>;
                
            }
        }

        public void ShowHistory() {
           foreach (string item in ExchangeHistory)
                Console.WriteLine(item);
        }

    }
}

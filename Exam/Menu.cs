using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace Exam
{

    public class Menu
    {
        
        TicketOffice office = new TicketOffice();

        string adminPassword = "admin";

        Semaphore pool = new Semaphore(0, 2);
        public void ShowMenu() {
            Load();
            Thread thread;
            string choise;
            do
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("1:Подивитись розклад;\n" +
                    "2:купити квиток;\n" +
                    "3:подивитись вільні місця на сьогодні;\n" +
                    "4:список постійних глядачів;\n0:зберегти та вийти");
                Console.WriteLine("------------------------------------------------------------");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        {
                            Load();
                            office.Schedule.ShowSchdule();
                            office.ShowPrices();
                            break;
                        }
                    case "2":
                        {
                            Load();
                            Console.WriteLine("Enter your name, surname, age  and phone number");
                            Viewer v;
                            try
                            {
                               v = new Viewer(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());
                            }
                            catch (Exception e) {
                                Console.WriteLine(e.Message);
                                break;
                            }
                            Console.WriteLine("Enter ticket type 1-registered, 2-unregistered");
                            try
                            {
                                 office.SellTicket(v, (TicketType)(int.Parse(Console.ReadLine())));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("wrong ticket type" + e);
                                break;
                            }

                            thread = new Thread(SaveThread);
                            thread.Start();
                            pool.Release(1);
                            break;
                        }
                    case "3":
                        {
                            Load();
                            office.ShowSessionsFreeSeatsToday(DateTime.Today);
                            break;
                        }

                    case "4":
                        {
                            Load();
                            office.ShowRegViewers();
                            break;
                        }
                    default:
                        break;
                }
               
            } while (choise != "0");
        }

        public void AddNewSchedule(Schedule s)
        {
            Console.WriteLine("enter password");
            if (Console.ReadLine() == adminPassword)
                 office.AddSchedule(s);
            Save();
        }

        private void Load() {
            if (File.Exists("office.bin"))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                using (Stream sr = new FileStream("office.bin", FileMode.Open, FileAccess.Read))
                {
                    office = binFormat.Deserialize(sr) as TicketOffice;
                }
            }
            else {
               Save();
            }
            //office.FromBinary();
        }

        private void SaveThread(){
            Save();
            pool.WaitOne();
            pool.Release();
            Load();
            //    office.ToBinary();

        }
        private void Save()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("office.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, office);
            }
            //    office.ToBinary();
        }




    }
}

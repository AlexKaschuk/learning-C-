using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Exam
{
    [Serializable]
    public class TicketOffice
    {

        public List<RegularViewer> Viewers = new List<RegularViewer>();

        public Schedule Schedule { get; set; } = new Schedule();

        //string viewersPath = "Viewers.bin";

        public double GetKoeficient(DateTime t) => t.Hour>=9&&t.Hour<=12?0.8: t.Hour >12 && t.Hour <= 19?1:1.2;


        static TicketOffice unique;

        public TicketOffice() { }

        public static TicketOffice Instance()
        {
            if (unique == null) unique = new TicketOffice();
            return unique;
        }

        public void ShowRegViewers() {
            Viewers.Sort((x,y) => x.NumberOfVisits.CompareTo(y.NumberOfVisits));
            if (Viewers.Count == 0)
            {
                Console.WriteLine("There is no reguler viewers");
            }
            else
            {
                foreach (RegularViewer i in Viewers)
                    Console.WriteLine($"{i.ToString()} NumberOfVisits {i.NumberOfVisits}");
            }
        }

        public void SellTicket(Viewer v, TicketType ticket) {
           DateTime session = chooseSession();
           CinemaHall h = Schedule.GetHall(session);
           h.ShowPrice(GetKoeficient(session));
           string[] z = chooseSeats(session).Split('/');
           if (h.BlockSits(int.Parse(z[0]), int.Parse(z[1])) == true)
            {
                Film c = Schedule.GetFilmName(session);
                Ticket tmpTicket = new Ticket(h.GetPrice(int.Parse(z[0]), GetKoeficient(session)), c.Name, session);
                tmpTicket.Seat = $"row:{z[0]}/seat:{z[1]};";
                if (ticket == TicketType.RegisteredTicket && v.Age > c.AgeLimit)
                    sellRegisteredTicket(tmpTicket, v);
                else if (v.Age < c.AgeLimit)
                    Console.WriteLine($"Age Limit {c.AgeLimit}");
                else
                {
                    v.BuyTicket(tmpTicket);
                    Console.WriteLine("You have bought the ticket\n" + v.Ticket.ToString());
                }
            }
  
        }

        private DateTime chooseSession() {
            Schedule.ShowSchdule();
            Console.WriteLine("Enter date and time of sessoin (hour, minute, day, month, year)");
            string[] z = Console.ReadLine().Split(',', ' ', '.');
            return new DateTime(int.Parse(z[4]), int.Parse(z[3]), int.Parse(z[2]), int.Parse(z[0]), int.Parse(z[1]), 0);
        }

        private string chooseSeats(DateTime session) {
            Schedule.ShowSessonSits(session);
            Console.WriteLine("Enter numder of row and seat (r/s)");
            return Console.ReadLine();
        }

        public void ShowSessionsFreeSeatsToday(DateTime session) => Schedule.ShowSessonSitsToday(session);

        public void AddSchedule(Schedule schedule) => Schedule = schedule;

        //public void ToBinary() {
             //using (FileStream fs = new FileStream(viewersPath, FileMode.Create, FileAccess.ReadWrite))
            //{
            //    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
            //    {
            //        foreach (RegularViewer i in Viewers)
            //        {
            //            bw.Write(i.Name);
            //            bw.Write(i.Surname);
            //            bw.Write(i.Age);
            //            bw.Write(i.PhoneNumber);
            //            bw.Write(i.NumberOfVisits);
            //        }
            //    }
            //}
            //Schedule.ToBinary();
       // }

        //public void FromBinary() {
            //if (File.Exists(viewersPath))
            //{
            //    using (FileStream fs = new FileStream(viewersPath, FileMode.Open, FileAccess.ReadWrite))
            //    {
            //        using (BinaryReader br = new BinaryReader(fs, Encoding.Unicode))
            //        {
            //            while (br.PeekChar() != -1)
            //            {
            //                RegularViewer tmp = new RegularViewer(br.ReadString(), br.ReadString(), br.ReadInt32(), br.ReadString());
            //                tmp.NumberOfVisits = br.ReadInt32();
            //                Viewers.Add(tmp);
            //            }
            //        }
            //    }
            //}
            //Schedule.FromBinary();
        //}

        private void sellRegisteredTicket(Ticket t, Viewer v) {
            RegisteredTicket tmp = new RegisteredTicket(t, $"{v.Surname} {v.Name}");
            
            if (Viewers.FindAll(x=>x.PhoneNumber==v.PhoneNumber&&x.Surname==v.Surname).Count>0)
            {
                Viewers.Find(x => x.PhoneNumber == v.PhoneNumber && x.Surname == v.Surname).NumberOfVisits++;
                int visits = Viewers.Find(x => x.PhoneNumber == v.PhoneNumber && x.Surname == v.Surname).NumberOfVisits;
                if (visits > 5)
                    tmp.Discount = 0.2;
                else if (visits > 10) t.Discount = 0.3;
                else tmp.Discount = 0.4;
                v.BuyTicket(t);
            }
            else
            {
                RegularViewer tmpViewer = new RegularViewer(v);
                tmpViewer.NumberOfVisits++;
                Viewers.Add(tmpViewer);
                v.BuyTicket(t);
            }
            Console.WriteLine("You have bought the ticket\n" + v.Ticket.ToString());

        }

        public void ShowPrices() {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("for sessions from 9.00 to 12.00 prices:");
                Schedule.Session.FirstOrDefault().Value.ShowPrice(0.8);
            }
            if (DateTime.Now.Hour < 19)
            {
                Console.WriteLine("for sessions from 12.00 to 19.00 prices:");
                Schedule.Session.FirstOrDefault().Value.ShowPrice(1);
            }
            if (DateTime.Now.Hour < 22)
            {
               Console.WriteLine("for sessions from 19.00 to 22.00 prices:");
               Schedule.Session.FirstOrDefault().Value.ShowPrice(1.2);
            }
        }

       
    }
}

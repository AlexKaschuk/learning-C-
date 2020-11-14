using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam
{
    [Serializable]
    public class Schedule
    {
        public SortedList<DateTime, CinemaHall> Session = new SortedList<DateTime, CinemaHall>();

        public SortedList<DateTime, Film> Films { get; } = new SortedList<DateTime, Film>();

        public void AddFilm(Film film) {
            DateTime startTime = DateTime.Today.AddHours(9); ;
            DateTime time = Films.LastOrDefault().Key.AddMinutes(film.Length + 15); //15 перерва між фільмами
            if (Films.Count == 0)
            {
                Films.Add(startTime, film);
                Session.Add(startTime, new CinemaHall());
            }
            else if (time.Hour > 22 || time.Hour == 0)
            {
                Films.Add(startTime.AddDays(1), film);
                Session.Add(startTime.AddDays(1), new CinemaHall());
            }
            else
            {
                Films.Add(time, film);
                Session.Add(time, new CinemaHall());
            }
        }

        public void ShowSchdule() {
            DateTime start = Films.FirstOrDefault().Key;

            foreach (KeyValuePair<DateTime, Film> pair in Films) {
                if (pair.Key > DateTime.Now)
                {
                    Console.WriteLine($"film {pair.Value} session {pair.Key}");
                }
            }
        }

        public void ShowSessonSits(DateTime date)
        {
            foreach (KeyValuePair<DateTime, Film> pair in Films)
            {
                if (pair.Key > DateTime.Now&& pair.Key.Day==date.Day&& pair.Key.Hour == date.Hour) {
                    Console.WriteLine($"film {pair.Value} session {pair.Key}");
                    Session.First(x => x.Key == pair.Key).Value.ShowSeats();
                }
            }
        }
        public void ShowSessonSits(string filmName)
                {
                    foreach (KeyValuePair<DateTime, Film> pair in Films)
                    {
                        if (pair.Key > DateTime.Now && pair.Value.Name == filmName)
                        {
                            Console.WriteLine($"film {pair.Value} session {pair.Key}");
                            Session.First(x => x.Key == pair.Key).Value.ShowSeats(); //first тому що він з таким ключем створюється один на один зал
                        }
                    }
                }

        public void ShowSessonSitsToday(DateTime date)
        {
            foreach (KeyValuePair<DateTime, Film> pair in Films)
            {
                if (pair.Key > DateTime.Now && pair.Key.Day == date.Day)
                {
                    Console.WriteLine($"film {pair.Value} session {pair.Key}");
                    Session.First(x => x.Key == pair.Key).Value.ShowSeats();
                }
            }
        }
        
        public CinemaHall GetHall(DateTime date) =>
             Session.First(x => x.Key == date).Value;
                
        public Film GetFilmName(DateTime date)
            => Films.First(x => x.Key == date).Value;

        //public void ToBinary()
        //{
        //    using (FileStream fs = new FileStream("film.bin", FileMode.Create, FileAccess.ReadWrite))
        //    {
        //        using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
        //        {
        //            foreach (KeyValuePair<DateTime, Film> i in Films)
        //            {
        //                bw.Write(i.Key.ToBinary());
        //                bw.Write(i.Value.Name);
        //                bw.Write(i.Value.Genre);
        //                bw.Write(i.Value.AgeLimit);
        //                bw.Write(i.Value.Length);
        //            }
        //        }
        //    }
            
        //    using (FileStream fs = new FileStream("hall.bin", FileMode.Create, FileAccess.ReadWrite))
        //    {
        //        using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
        //        {
        //            foreach (KeyValuePair<DateTime, CinemaHall> i in Session)
        //            {
        //                bw.Write(i.Key.ToBinary());
        //                bw.Write(i.Value.GetBlockedSeats());
        //            }
        //        }
        //    }

        //}

        //public void FromBinary()
        //{
        //    Films.Clear();
        //    if (File.Exists("film.bin"))
        //    {
        //        using (FileStream fs = new FileStream("film.bin", FileMode.Open, FileAccess.ReadWrite))
        //        {
        //            using (BinaryReader br = new BinaryReader(fs, Encoding.Unicode))
        //            {
        //                while (br.BaseStream.Position != br.BaseStream.Length)
        //                {
        //                    Films.Add(DateTime.FromBinary(br.ReadInt64()), new Film(br.ReadString(), br.ReadString(), br.ReadInt32(), br.ReadInt32()));
        //                }
        //            }
        //        }
        //    }
        //    Session.Clear();
        //    if (File.Exists("hall.bin"))
        //    {
        //        using (FileStream fs = new FileStream("hall.bin", FileMode.Open, FileAccess.ReadWrite))
        //        {
        //            using (BinaryReader br = new BinaryReader(fs, Encoding.Unicode))
        //            {
        //                while (br.BaseStream.Position != br.BaseStream.Length)
        //                {
        //                    DateTime d = DateTime.FromBinary(br.ReadInt64());
        //                    string[] blockedSits = br.ReadString().Split(',', '\n', ' ');
        //                    CinemaHall h = new CinemaHall();
        //                    if (blockedSits.Length > 1)
        //                    {
        //                        for (int i = 0; i < blockedSits.Length; i+=2)
        //                        {
        //                            if(blockedSits[i] != " "&& blockedSits[i] != "") { 
        //                               h.BlockSits(int.Parse(blockedSits[i]), int.Parse(blockedSits[i + 1]));
        //                            }
        //                        }
        //                    }
        //                    Session.Add(d, h);
        //                }
        //            }
        //        }
        //    }

        //}

    }
}

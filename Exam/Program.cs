using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Schedule schedule = new Schedule();
            schedule.AddFilm(new Film("міцний горішок", "бойовик", 12, 145));
            schedule.AddFilm(new Film("міцний горішок2", "бойовик", 12, 160));
            schedule.AddFilm(new Film("міцний горішок3", "бойовик", 12, 125));
            schedule.AddFilm(new Film("міцний горішок4", "бойовик", 12, 115));
            schedule.AddFilm(new Film("міцний горішок5", "бойовик", 12, 155));
            schedule.AddFilm(new Film("Aliens", "бойовик, жахи", 12, 125));
            schedule.AddFilm(new Film("Aliens", "бойовик, жахи", 12, 135));
            schedule.AddFilm(new Film("Aliens", "бойовик, жахи", 12, 155));
            



            Menu m = new Menu();
          //m.AddNewSchedule(schedule);
           
           m.ShowMenu();

           




        }
    }
}

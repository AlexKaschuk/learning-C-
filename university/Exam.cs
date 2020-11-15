using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class Exam
    {
        public string ExamObj { get; set; }
        public int ExamGrade { get;
            set;  }
        public DateTime ExamDate { get; set; }


        public Exam(string Obj, int grade, DateTime date) {

            ExamObj = Obj;
            ExamGrade = grade;
            ExamDate = date;
         }

        public Exam() : this("", 0, DateTime.Today) { }

        public override string ToString() =>
           $"Exam date: {ExamDate.ToShortDateString()}, Exam object - {ExamObj}, grade {ExamGrade}\n";

       




    }
}

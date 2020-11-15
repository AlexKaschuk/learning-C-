using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace university2
{
   public class Exam: IComparable<Exam>, IComparer<Exam>
    {
        public string ExamObj { get; }
        private int mark;
        public DateTime ExamDate { get; }

        public int Mark {
            get => mark;
            private set {
                if (value >= 1 && value <= 12) mark = value;
                else throw new ArgumentException("not correct mark");
            }
        }


        public Exam() { }
        public Exam(string Obj, int ExamMark, DateTime date) {

            ExamObj = Obj;
            Mark = ExamMark;
            ExamDate = date;
        }

        public override string ToString()=>
            $"Exam: {ExamObj}; date: {ExamDate.ToShortDateString(),15}; mark: {Mark, 5}";

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Exam))
                return false;
            Exam e = obj as Exam;
            if (e.ExamObj == this.ExamObj && e.ExamDate == this.ExamDate && e.Mark == this.Mark)
                return true;
            return false;
        }

        public override int GetHashCode()=>
            // return this.ToString().GetHashCode();
          (ExamObj,ExamDate,Mark).GetHashCode();

        //int IComparable.CompareTo(object obj)
        //{
        //    if (obj == null || !(obj is Exam))
        //        throw new ArgumentException ("it is not exam");
        //    return this.ExamDate.CompareTo((obj as Exam).ExamDate);
        //}

        int IComparable<Exam>.CompareTo(Exam other)=> ExamObj.CompareTo(other?.ExamObj);

        int IComparer<Exam>.Compare(Exam x, Exam y) => x.Mark.CompareTo(y.Mark);
 
        public static  bool operator == (Exam e1, Exam e2) => e1.Equals(e2);
        public static bool operator !=(Exam e1, Exam e2) => !e1.Equals(e2);
     }
}

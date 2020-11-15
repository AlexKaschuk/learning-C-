using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university2
{
    class ExamComparerByDate : IComparer<Exam>
    {
        public int Compare(Exam x, Exam y)=> x.ExamDate.CompareTo(y.ExamDate);

    }
}

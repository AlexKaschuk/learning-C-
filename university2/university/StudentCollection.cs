using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university2
{
    public class StudentCollection<TKey>: IEnumerable<KeyValuePair<TKey, Student>>
    {

        public Dictionary<TKey, Student> Students { get; private set; } = new Dictionary<TKey, Student>();

        public void AddStudent(TKey key, Student student) => Students.Add(key, student);
        
        public IEnumerator<KeyValuePair<TKey, Student>> GetEnumerator() => Students.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            string tmp = "";
            foreach (KeyValuePair<TKey, Student> pair in Students)
                tmp += Students[pair.Key].ToString() + "\n";
            return tmp;
        }

        public string ToShortString() {
            string tmp = "";
            foreach (KeyValuePair<TKey, Student> pair in Students)
                tmp += Students[pair.Key].ToShortString() + "\n";
            return tmp;
        }


        public double MaxAverageMark {
            get {
                if (Students.Count() == 0)
                    return 0.0;
                return Students.Select(e => (e.Value as Iratable).Rate).Max();       
            }
        }

        public IEnumerable<KeyValuePair<TKey, Student>> EducationForm(Education value) =>
            Students.Where(x => x.Value.Education == value);
        
     

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamHomeTask
{
    class PhoneFinder
    {

        private List<Employee> Employees = new List<Employee>();

        public string pathToFile { get; set; }

        public PhoneFinder(string path) =>
            pathToFile = path;
       

        private void ToBynary() 
        {
            if (!File.Exists(pathToFile))
            {
                using (FileStream fs = new FileStream(pathToFile, FileMode.Create, FileAccess.ReadWrite))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
                    {
                        foreach (Employee i in Employees) bw.Write(i.ToString());
                    }
                }
            }
            else {
                using (FileStream fs = new FileStream(pathToFile, FileMode.Truncate, FileAccess.ReadWrite))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
                    {
                        foreach (Employee i in Employees) bw.Write(i.ToString());
                    }
                }
            }
            
        }

        private void FromBynary()
        {
            Employee tmp = new Employee();
            if (pathToFile!=null&& File.Exists(pathToFile)) {
                using (FileStream fs = new FileStream(pathToFile, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (BinaryReader br = new BinaryReader(fs, Encoding.Unicode))
                    {
                        while (br.PeekChar()!=-1) 
                        {
                            tmp.FromString(br.ReadString());
                            if (!Employees.Contains(tmp)) 
                                Employees.Add(tmp);
                        }
                   }
                } 
            }
        }

        public void AddEmployee(params Employee[] any) =>
            Employees.AddRange(any);


        public void FindNumber(int id)=>
               Console.WriteLine(Employees.Find(x => x.Id == id) != null ? Employees.Find(x => x.Id == id).ToString() : "not founded");
       

        public void FindNumber(string name)=>
            Console.WriteLine(Employees.Find(x => x.Name == name || x.Surname == name) != null ? Employees.Find(x => x.Name == name || x.Surname == name).ToString() : "not founded");
 
        public void SaveNumbers() => ToBynary();

        public void PrintAllNums() {
            foreach (Employee i in Employees)
                Console.WriteLine(i.ToString());
        }

    }
}

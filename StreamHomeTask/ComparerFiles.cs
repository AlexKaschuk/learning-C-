using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamHomeTask
{
    public static class ComparerFiles
    {
        public static void CompareFiles(string path1, string path2)
        {

            using (FileStream fs1 = new FileStream(path1, FileMode.Open, FileAccess.Read), fs2 = new FileStream(path2, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader fr1 = new StreamReader(fs1, Encoding.UTF8), fr2 = new StreamReader(fs2, Encoding.UTF8))
                {
                    int rows = 0;
                    string tmp1, tmp2;
                    while (!fr1.EndOfStream)
                    {
                        tmp1 = fr1.ReadLine();
                        tmp2 = fr2.ReadLine();
                        rows++;
                        if (tmp1 != tmp2)
                        {
                            if (tmp1.Length >= tmp2.Length) StrComp(tmp1, tmp2, rows);
                            else StrComp(tmp2, tmp1, rows);
                            break;
                        }
                    }
                }
            }
        }

        private static void StrComp(string a, string b, int rows)
        {
            bool flag = false;
            for (int i = 0; i < b.Length; ++i)
                {
                 if (a[i] != b[i])
                 {
                   Console.WriteLine($"string №{rows} in files not equal, position {i} chars {a[i]} : {b[i]} is different");
                   flag = true;
                   break;
                 };
            }
            if (flag == false) Console.WriteLine($"string №{rows} in files not equal, position: {b.Length+1}:char:{a[b.Length]} is first different character in files");
        }
    }
}
   

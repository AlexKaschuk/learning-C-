using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarbageCollector;
using System.Runtime.InteropServices;

namespace AddDll
{
    class Program
    {
       public static class Externals {
            [DllImport("kernel32.dll")]
            public static extern IntPtr GetConsoleWindow();

            [DllImport("user32.dll")]
            public static extern int MessageBox(IntPtr hParentWindow, string msg, string caption, int style); 



        }
        

        
        static void Main(string[] args)
        {
            using (IntArray a = new IntArray(5)) {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = i + 1;
                    sum += a[i];
                }

                IntPtr hWin = Externals.GetConsoleWindow();
                Externals.MessageBox(hWin, sum.ToString(), "sum", 0);



            
            }



        }
    }
}

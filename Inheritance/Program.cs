using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] info = new double[56500 / 78];
            for (int i = 0; i < info.Length; i++)
                info[i] = 780;
            
            Flash myFlash = new Flash("Samsung", "F20", 20000);
            Flash myFlash1 = new Flash("Samsung", "F20", 300000);
            Console.WriteLine(myFlash.StorageInfo());
            HDD h = new HDD("Sumsung", "asd", 150000);

            HDD h2 = new HDD("Sumsung", "asd", 150000);
            StorageManager M = new StorageManager(myFlash, myFlash1, h, h2);
            M.TimeToCopy(info);
            M.CopyInfo(info);
            M.StoragesInfo();

            M.StorageQuantity(h, info);


        }
    }
}

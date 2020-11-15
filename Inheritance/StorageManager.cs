using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class StorageManager
    {

        private Storage[] storages;

        public StorageManager() {
            storages = new Storage[0];
        }

        public StorageManager(params Storage[] someStorages) {
            storages = new Storage[someStorages.Length];
            for (int i = 0; i < storages.Length; ++i)
                storages[i] = someStorages[i];
        }



        public double GeneralMemoryInStorages() => storages.Select(x => x.GetMemory()).Sum();

        public void CopyInfo(params double[] info) {
            double timeCopy = 0;
            if (info.Sum() < GeneralMemoryInStorages())
            {
                int j = 0;
                for (int i = 0; i < storages.Length; ++i)
                {
                    do
                    {
                        storages[i].CopyToDisc(info[j]);
                        timeCopy += storages[i] is Flash ? info[j] / Flash.CopySpeed : storages[i] is DVD ? info[j] / DVD.WriteReadSpeed : info[j] / HDD.CopySpeed;
                        j++;
                        if (j == info.Length) break;
                    } while (storages[i].GetFreeMemory() > info[j]);
                }
                Console.WriteLine($"copied, time {timeCopy} sec");
            }
            else
            {
                Console.WriteLine("not enough free memory");
            }
        
        }

        public void TimeToCopy(params double[] info) =>
            Console.WriteLine($"time to copy info to Flash = {info.Sum()/Flash.CopySpeed} sec\ntime to copy info to DVD = {info.Sum() / DVD.WriteReadSpeed} sec\ntime to copy info to HDD = {info.Sum() / HDD.CopySpeed} sec");

        public void StoragesInfo() {
            foreach (Storage item in storages)
                Console.WriteLine(item.StorageInfo());
        }

        public void StorageQuantity(Storage any, params double[] info) {

            if (any is Flash) Console.WriteLine($"needed {info.Sum()/((Flash)any).GetMemory()} storages to copy all info" );
            if (any is HDD) Console.WriteLine($"needed {info.Sum()/((HDD)any).GetMemory()} storages to copy all info" );
            if (any is DVD) Console.WriteLine($"needed {info.Sum()/((DVD)any).GetMemory()} storages to copy all info" );
       
        }



    }
}

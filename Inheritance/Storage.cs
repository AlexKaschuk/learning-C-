using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract public class Storage
    {
        private string _storageName;
        private string _storageModel;

        
        public Storage(string name, string model) {
            _storageName = name;
            _storageModel = model;
        }

        public string StorageName{
            get=>_storageName;//перевірку на нул не роблю через відсутність конструктора без параметрів, щоб зразу називали диски
            set => _storageName = value;
        }

        public string StorageModel { get=> _storageModel; }
        public abstract double GetMemory();
        public abstract void CopyToDisc(double itemMemoryWeightInMB);
        public abstract double GetFreeMemory();
        public abstract string StorageInfo();


    }
}

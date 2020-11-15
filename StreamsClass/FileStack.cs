using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsClass
{
    public class FileStack
    {
        Stack<string> stack = new Stack<string>();
        public FileInfo FInfo { get; set; }

        private void LoadFileToStack() {
            stack.Clear();
            if (FInfo.Exists)
            {
                using (StreamReader sr = FInfo.OpenText())
                {
                    while (!sr.EndOfStream)
                        stack.Push(sr.ReadLine());
                }
            }
        }

        public void CreateReverseFile() {
            LoadFileToStack();
            FileInfo reversFInfo = new FileInfo(Path.Combine(FInfo.DirectoryName, "reverse" + FInfo.Name));
            using (StreamWriter wr = reversFInfo.CreateText()) {
                while (stack.Count != 0) {
                    wr.WriteLine(stack.Peek());
                    stack.Pop();
                }
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsClass
{
    public struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }
        public ConsoleColor Color { get; set; }

        public void WriteToBinary(BinaryWriter bwr) {
            bwr.Write(X);
            bwr.Write(Y);
            bwr.Write(Color.ToString());
        }

        public void BinaryReader(BinaryReader br)
        {
            X = br.ReadInt32();
            Y = br.ReadInt32();
            Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), br.ReadString()) ;

        }




    }
}

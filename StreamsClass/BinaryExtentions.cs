using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsClass
{
    public static class BinaryExtentions
    {
        public static void Write(this BinaryWriter bw, Point point) {
            bw.Write(point.X);
            bw.Write(point.Y);
            bw.Write(point.Color.ToString());
        } 
        
        public static Point  Read(this BinaryReader br) {
            Point p = new Point();
            p.X = br.ReadInt32();
            p.Y = br.ReadInt32();
            p.Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), br.ReadString());
            return p;
        }

    }
}

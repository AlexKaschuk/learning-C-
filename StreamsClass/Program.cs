using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamsClass
{
    class Program
    {
        static void Main(string[] args)
        {

           
           // string fileName = @"..\..\text.txt";
            {//FileStream fileStream;
            {
                //using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                //    {
                //    byte[] byteStream = new byte[fileStream.Length];
                //    fileStream.Read(byteStream,0,byteStream.Length);
                //    Console.WriteLine(Encoding.UTF8.GetString(byteStream));
                //    };


                //using (fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None)) 
                //{
                //    using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8)) {

                //        Console.WriteLine(streamReader.ReadToEnd());
                //        if(streamReader.BaseStream.CanSeek) streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //        while (!streamReader.EndOfStream)
                //            Console.WriteLine(streamReader.ReadLine());
                //    };
                //};

                //FileInfo file = new FileInfo(fileName) ;
                //using (StreamWriter sw = file.AppendText()) { sw.WriteLine(Console.ReadLine()); }
            }
            //DriveInfo[] di = DriveInfo.GetDrives();

            //foreach (DriveInfo i in di)
            //{
            //    if(i.IsReady)
            //        Console.WriteLine($"{i.RootDirectory} : {i.TotalSize} : {i.AvailableFreeSpace} ");
            //}

            //DirectoryInfo[] infos = di[1].RootDirectory.GetDirectories();
            //foreach (DirectoryInfo i in infos)
            //    Console.WriteLine(i.FullName);


            //DirectoryInfo dir = new DirectoryInfo(@"..\..\.");
            //int fcounter = 0;
            //FileInfo[] fifi = dir.GetFiles(Console.ReadLine(), SearchOption.AllDirectories);

            //foreach (FileInfo f in fifi) {
            //    Console.WriteLine($"{++fcounter}, {f.Name}");
            //}

            //FileStack fs = new FileStack { FInfo = fifi[0] };


            //fs.CreateReverseFile();
            }

            Random r = new Random();
            List<Point> lp = new List<Point>();
            for(int i = 0; i<10; ++i)
                 lp.Add(new Point { X = r.Next(14), Y = r.Next(14), Color = (ConsoleColor)r.Next(14) });

            using (FileStream fs = new FileStream("points.bin",FileMode.Create, FileAccess.ReadWrite) )
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach (Point p in lp)
                        BinaryExtentions.Write(bw, p);

                        //p.WriteToBinary(bw);

                }
            }

            using (FileStream fs1 = new FileStream("points.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (BinaryReader br = new BinaryReader(fs1))
                {
                    lp.Clear();
                    Point cp = new Point();
                    while (br.BaseStream.Position != br.BaseStream.Length) {
                        //cp.BinaryReader(br);
                        cp = BinaryExtentions.Read(br);

                        lp.Add(cp);
                     }
                 }
            }

            lp.ForEach(p => Console.WriteLine($"{p.X} : {p.Y} : {p.Color}"));




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace GraficsC
{
    static class WinApi
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hendl);
    }

    public class ConsoleGraphics: IGrapphics
    {
        public Graphics GetGraphics()
        {
            IntPtr ConsoleHandle = WinApi.GetConsoleWindow();
            IntPtr DeviceContextHandle = WinApi.GetDC(ConsoleHandle);
            return Graphics.FromHdc(DeviceContextHandle);
        }
    }



}

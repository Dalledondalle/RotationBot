using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows;

namespace RotationBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            Color c = new Color();
            while (s.ElapsedMilliseconds < 1000)
            {               
                int x = 400;
                int y = 250;
                c = GetColorAt(x, y);                
            }
            Console.WriteLine($"R: {c.R} \nG: {c.G} \nB: {c.B}");
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds.ToString() + "Milisecs");
            Console.ReadKey();
            Main(args);
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public static Color GetColorAt(int x, int y)
        {            
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        
    }
}

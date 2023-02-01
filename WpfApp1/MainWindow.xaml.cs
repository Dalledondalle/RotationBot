using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace WpfApp1
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public static System.Drawing.Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return System.Drawing.Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Keyboard.HoldKey(1000);
        }
    }
    public class Keyboard
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        const int KEY_DOWN_EVENT = 0x0001; //Key down flag
        const int KEY_UP_EVENT = 0x0002; //Key up flag

        public static void HoldKey(int duration)
        {
            byte key = (byte)Key.A;
            int totalDuration = 0;
            while (totalDuration < duration)
            {
                keybd_event(key, 0, KEY_DOWN_EVENT, 0);
                keybd_event(key, 0, KEY_UP_EVENT, 0);
                System.Threading.Thread.Sleep(10);
                totalDuration += 10;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsInput;
using WindowsInput.Native;

namespace Puntero_Windows
{
    public class SimulateInteraction
    {
        
        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);


        Form1 Main;
        InputSimulator sim;


        public SimulateInteraction(Form1 main)
        {
            Main = main;
            sim = new InputSimulator();
        }

        public void KeyRightDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
        }
        public void KeyLeftDown()
        {
            sim.Keyboard.KeyDown(VirtualKeyCode.LEFT);
        }
    }

    public static class Window
    {
        public static bool Find(Func<IntPtr, bool> fn)
        {
            return EnumWindows((hwnd, lp) => !fn(hwnd), 0) == 0;
        }
        public static string GetClassName(IntPtr hwnd)
        {
            var sb = new StringBuilder(1024);
            GetClassName(hwnd, sb, sb.Capacity);
            return sb.ToString();
        }
        public static uint GetProcessId(IntPtr hwnd)  // {0:X8} 
        {
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            return pid;
        }
        public static string GetText(IntPtr hwnd)
        {
            var sb = new StringBuilder(1024);
            GetWindowText(hwnd, sb, sb.Capacity);
            return sb.ToString();
        }

        delegate bool CallBackPtr(IntPtr hwnd, int lParam);

        [DllImport("user32.dll")]
        static extern int EnumWindows(CallBackPtr callPtr, int lPar);

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("User32", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int W, int H, uint uFlags);
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Penguin.Helper
{
    public class WindowHelper
    {
        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool turnon);

        //now we have switch window.
        public static void SwitchWindow(string ProcWindow)
        {
            Process[] procs = Process.GetProcessesByName(ProcWindow);
            foreach (Process proc in procs)
            {
                //switch to process by name
                SwitchToThisWindow(proc.MainWindowHandle, false);
            }
        }

        public static string GetWindowTitle()
        {
            IntPtr activeWindow = GetForegroundWindow();
            List<String> strListProicesses = new List<string>();
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if (activeWindow == process.MainWindowHandle)
                    {
                        return process.ProcessName;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return null;
        }
    }
}

using System.Runtime.InteropServices;

namespace CSC440Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Create and open console
            NativeMethods.AllocConsole();
            Console.WriteLine("Log Console");

            //start application
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }


        //Class to enable a console to be opened with the program (used for debugging / program logs)
        internal static class NativeMethods
        {
            /// <summary>
            /// Allocates a new console for the calling process.
            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern int AllocConsole();

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern int FreeConsole();
        }
    }
}
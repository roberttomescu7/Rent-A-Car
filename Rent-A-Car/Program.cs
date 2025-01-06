using System.Runtime.InteropServices;

namespace Rent_A_Car
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuForm());
        }

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
    }
}
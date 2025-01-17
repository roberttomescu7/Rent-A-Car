using System.Runtime.InteropServices;

namespace Rent_A_Car
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            //AllocConsole();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuForm());
        }

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
    }
}
using NeuroBuddy.Core;
using NeuroBuddy.Interfaces;
using NeuroBuddy.Mocks;
using NeuroBuddy.Views;

namespace NeuroBuddy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new MainWindow(new UserdatabaseManagerMock()));
        }
    }
}
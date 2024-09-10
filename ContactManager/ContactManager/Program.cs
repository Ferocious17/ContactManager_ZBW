using ContactManager.DB;
using ContactManager.Forms;
using System.Net.Mime;

namespace ContactManager
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
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler((sender, args) =>
            {
                MessageBox.Show("An unexpected error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
            ApplicationConfiguration.Initialize();

            using ContactManagerContext context = new();
            if (!context.IsDatabaseAvailable())
            {
                MessageBox.Show("Database is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Login login = new();
            if (login.ShowDialog() == DialogResult.OK)
            {
                StartWindow startWindow = new()
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = login.Location
                };
                Application.Run(startWindow);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
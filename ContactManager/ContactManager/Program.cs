using ContactManager.Forms;

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
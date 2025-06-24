using UMS.Data;
using UMS.Views;

namespace UMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseInitializer.CreateTables();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                // Automatically create tables if DB file exists
                if (!System.IO.File.Exists("UMS_DB.db"))
                {
                    MessageBox.Show("Database file not found. Please ensure 'UMS_DB.db' is in the application directory.", "Missing Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Initialize tables if needed
                DatabaseInitializer.CreateTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database initialization failed: {ex.Message}", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Application.Run(new MainForm());
            Application.Run(new LoginForm());
        }
    }
}
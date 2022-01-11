namespace LibraryManager
{
    using System;
    using System.Windows.Forms;

    using LibraryManager.Database.Data;

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Ensure that database is created
            var db = new LibraryManagerContext();
            db.Database.EnsureDeleted();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }
    }
}

namespace LibraryManager
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using LibraryManager.Database.Data;
    using LibraryManager.SendGrid;

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ////Ensure that database is created
            //var db = new LibraryManagerContext();
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();
            //var book = new Book() { Author = "Steven", Name = "MyFirstBook", Year = 1999 };
            //db.Books.Add(book);
            //db.SaveChanges();
            //var sendGrid = new SendGridEmailSender(ConfigurationConstants.SENDGRIP_APIKEY);
            //await sendGrid.SendEmailAsync("ghostinthewires@abv.bg", "emo", "azsumemi@gmail.com", "test", "First email send");
            Console.WriteLine(ConfigurationConstants.SERVER_NAME);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

namespace LibraryManager
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using AutoMapper;
    using LibraryManager.Automapper;
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
            var db = new LibraryManagerContext();
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            //var book = new Book() { Author = "Steven", Name = "MyFirstBook", Year = 1999 };
            //db.Books.Add(book);
            //db.SaveChanges();
            var sendGrid = new SendGridEmailSender(ConfigurationConstants.SENDGRID_APIKEY);

            //start automapper
            AutoMapperConfig.RegisterMappings(Assembly.GetExecutingAssembly());
            //sender, sender name, receiver
            //await sendGrid.SendEmailAsync("azsumemi@gmail.com", "emo", "ghostinthewires@abv.bg", "test", "Second email send");
            Console.WriteLine(ConfigurationConstants.SERVER_NAME);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

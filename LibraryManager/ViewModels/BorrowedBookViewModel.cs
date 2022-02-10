namespace LibraryManager.ViewModels
{
    using System;

    using LibraryManager.Automapper;
    using LibraryManager.Database.Models;

    public class BorrowedBookViewModel : BookViewModel, IMapFrom<BorrowedBook>
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

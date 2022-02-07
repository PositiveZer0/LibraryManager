namespace LibraryManager.ViewModels
{
    using LibraryManager.Automapper;
    using LibraryManager.Database.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BorrowedBookViewModel : BookViewModel, IMapFrom<BorrowedBook>
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

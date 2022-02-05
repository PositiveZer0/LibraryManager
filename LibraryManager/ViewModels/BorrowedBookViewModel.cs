namespace LibraryManager.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BorrowedBookViewModel : BookViewModel
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

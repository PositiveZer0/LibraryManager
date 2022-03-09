namespace LibraryManager.Services.Admin
{
    using LibraryManager.Database.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAdminService
    {
        Task UpdateBookAsync(Book book, int id);
        Book GetBookById(int id);
    }
}

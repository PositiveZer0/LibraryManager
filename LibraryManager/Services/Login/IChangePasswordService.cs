namespace LibraryManager.Services.Login
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IChangePasswordService
    {
        Task Change(string email, string passsword);
    }
}

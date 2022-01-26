namespace LibraryManager.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ILoginService
    {
        string Login(string email, string password);
    }
}

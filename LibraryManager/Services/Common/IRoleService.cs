namespace LibraryManager.Services.Common
{
    using LibraryManager.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IRoleService
    {
        UserViewModel GetCurrentUser();
    }
}

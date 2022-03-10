namespace LibraryManager.Services.Common
{
    using LibraryManager.ViewModels;

    public interface IRoleService
    {
        UserViewModel GetCurrentUser();
    }
}

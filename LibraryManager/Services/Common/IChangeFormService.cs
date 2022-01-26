namespace LibraryManager.Services.Common
{
    using System.Windows.Forms;

    public interface IChangeFormService
    {
        void Change(Form current, Form next);
    }
}

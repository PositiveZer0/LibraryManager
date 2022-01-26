namespace LibraryManager.Services.Common
{
    using System.Windows.Forms;

    public class ChangeFormService : IChangeFormService
    {
        public void Change(Form current, Form next)
        {
            current.Hide();
            var nextForm = next;
            nextForm.Closed += (s, args) => current.Close();
            nextForm.Show();
        }
    }
}

namespace LibraryManager.Services.Login
{
    using System.Threading.Tasks;

    public interface ISixDigitCodeValidator
    {
        Task GenerateAsync(string email);

        Task ResendCode(string email);

        bool IsValid(string email, string code);

        Task ValidateAsync(string email);
    }
}

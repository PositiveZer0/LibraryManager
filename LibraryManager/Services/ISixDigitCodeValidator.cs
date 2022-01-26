namespace LibraryManager.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface ISixDigitCodeValidator
    {
        Task GenerateAsync(string email);

        Task ResendCode(string email);

        bool IsValid(string email, string code);

        Task ValidateAsync(string email);
    }
}

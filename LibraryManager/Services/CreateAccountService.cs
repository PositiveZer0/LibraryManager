﻿namespace LibraryManager.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using System.Text;
    using System.Text.RegularExpressions;

    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.ValidationCreateAccount;

    public class CreateAccountService : ICreateAccountService
    {
        private IDeletableEntityRepository<User> user;

        public CreateAccountService(IDeletableEntityRepository<User> user)
        {
            this.user = user;
        }

        public async Task CreateAccount(string name, string surname, string email, string password, string role, bool verifyEmail)
        {
            var account = new User
            {
                Name = name,
                Surname = surname,
                Email = email,
                Password = SecurePasswordHasher.Hash(password),
                Role = role,
                IsEmailVerified = verifyEmail,
            };
            await this.user.AddAsync(account);
            await this.user.SaveChangesAsync();
        }

        public string ValidateAccount(string name, string surname, string email, string password, string confirmPassword)
        {
            var result = new StringBuilder();
            //name validation
            var nameAttr = "Name";
            var nameValidator = new NameAndSurnameValidator(name, nameAttr);
            result.AppendLine(nameValidator.Validate());

            //surname validation
            var surnameAttr = "Surname";
            var surnameValidator = new NameAndSurnameValidator(surname, surnameAttr);
            result.AppendLine(surnameValidator.Validate());

            //email validation
            var emailValidator = new EmailValidator(email);
            result.AppendLine(emailValidator.Validate());

            //password validation
            var passwordValidator = new PasswordValidator(password, confirmPassword);
            result.AppendLine(passwordValidator.Validate());
            
            var removeEmptyLinesResult = Regex.Replace(result.ToString(), @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            return removeEmptyLinesResult.TrimEnd();
        }
        
    }
}

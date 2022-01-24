namespace LibraryManager.Services
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.Services.Validation;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

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
                Password = password,
                Role = role,
                IsEmailVerified = true,
            };
            await this.user.AddAsync(account);
            var a = this.user.All().Where(x => x.IsEmailVerified == true).FirstOrDefault();
            this.user.Delete(a);
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

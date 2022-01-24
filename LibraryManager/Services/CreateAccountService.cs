namespace LibraryManager.Services
{
    using LibraryManager.Database.Data;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
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
            result.AppendLine(InputShouldBeBetweenTwoAndThirtyCharacters(name, nameAttr));
            result.AppendLine(InputShouldContainOnlyLetters(name, nameAttr));
            result.AppendLine(InputShouldStartWithUpperLetter(name, nameAttr));

            //surname validation
            var surnameAttr = "Surname";
            result.AppendLine(InputShouldBeBetweenTwoAndThirtyCharacters(surname, surnameAttr));
            result.AppendLine(InputShouldContainOnlyLetters(surname, surnameAttr));
            result.AppendLine(InputShouldStartWithUpperLetter(surname, surnameAttr));

            //email validation
            result.AppendLine(EmailShouldBeValid(email));

            //password validation
            result.AppendLine(PasswordAndConfrimPasswordShouldMatch(password, confirmPassword));
            result.AppendLine(PasswordShouldBeBetweenEightAndSixteenCharacters(password));
            result.AppendLine(PasswordShouldContainAtLeastOneLetter(password));
            
            var removeEmptyLinesResult = Regex.Replace(result.ToString(), @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            return removeEmptyLinesResult.TrimEnd();
        }

        #region name and surname validation
        private string InputShouldBeBetweenTwoAndThirtyCharacters(string input, string name)
        {
            if (input.Length < 2 || input.Length > 30)
            {
                return $"{name} should be between 2 and 30 characters";
            }

            return string.Empty;
        }

        private string InputShouldContainOnlyLetters(string input, string name)
        {
            var isLetter = true;

            foreach (var ch in input)
            {
                if (!Char.IsLetter(ch))
                {
                    isLetter = false;
                }
            }

            return isLetter ? string.Empty : $"{name} should contains only letters";
        }

        private string InputShouldStartWithUpperLetter(string input, string name)
        {
            var letter = Char.IsUpper(input[0]);

            return letter ? string.Empty : $"{name} should start with upper letter";
        }

        private static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("String is empty!");
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }
        #endregion

        #region validate email
        private string EmailShouldBeValid(string email)
        {
            var validator = new EmailAddressAttribute();

            return validator.IsValid(email) ? null : "Email should be valid";
        }
        #endregion

        #region password validation
        private string PasswordAndConfrimPasswordShouldMatch(string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                return "Password and Confirm password are different";
            }
            return null;
        }

        private string PasswordShouldBeBetweenEightAndSixteenCharacters(string password)
        {
            if (password.Length < 8 || password.Length > 16)
            {
                return "Password should be between eight and sixteen characters";
            }
            return null;
        }

        private string PasswordShouldContainAtLeastOneLetter(string password)
        {
            var hasLetter = false;
            foreach (var ch in password)
            {
                if (Char.IsLetter(ch))
                {
                    hasLetter = true;
                }
            }

            return hasLetter ? null : "Password should contain at least one letter";
        }
        #endregion
    }
}

namespace LibraryManager.Services.ValidationCreateAccount
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PasswordValidator
    {
        private readonly string password;
        private readonly string confirmPassword;
        private readonly StringBuilder result;

        public PasswordValidator(string password, string confirmPassword)
        {
            this.password = password;
            this.confirmPassword = confirmPassword;
            this.result = new StringBuilder();
        }
        
        public string Validate()
        {
            this.result.AppendLine(PasswordAndConfrimPasswordShouldMatch());
            this.result.AppendLine(PasswordShouldBeBetweenEightAndSixteenCharacters());
            this.result.AppendLine(PasswordShouldContainAtLeastOneLetter());

            return this.result.ToString();
        }

        private string PasswordAndConfrimPasswordShouldMatch()
        {
            if (this.password != this.confirmPassword)
            {
                return "Password and Confirm password are different";
            }
            return null;
        }

        private string PasswordShouldBeBetweenEightAndSixteenCharacters()
        {
            if (this.password.Length < 8 || this.password.Length > 16)
            {
                return "Password should be between eight and sixteen characters";
            }
            return null;
        }

        private string PasswordShouldContainAtLeastOneLetter()
        {
            var hasLetter = false;
            foreach (var ch in this.password)
            {
                if (Char.IsLetter(ch))
                {
                    hasLetter = true;
                }
            }

            return hasLetter ? null : "Password should contain at least one letter";
        }
    }
}

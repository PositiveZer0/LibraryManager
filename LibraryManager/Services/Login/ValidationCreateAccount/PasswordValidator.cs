namespace LibraryManager.Services.Login.ValidationCreateAccount
{
    using System;
    using System.Text;

    public class PasswordValidator
    {
        private string password;
        private string confirmPassword;
        private readonly StringBuilder result;

        public PasswordValidator()
        {
            this.result = new StringBuilder();
        }
        
        public string Validate(string password, string confirmPassword)
        {
            this.password = password;
            this.confirmPassword= confirmPassword;

            this.result.AppendLine(PasswordAndConfrimPasswordShouldMatch());
            this.result.AppendLine(PasswordShouldBeBetweenEightAndSixteenCharacters());
            this.result.AppendLine(PasswordShouldContainAtLeastOneLetter());

            return this.result.ToString().TrimEnd();
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

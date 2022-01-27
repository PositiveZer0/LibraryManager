namespace LibraryManager.Services.Login.ValidationCreateAccount
{
    using System.Linq;
    using System.Text;
    using System.ComponentModel.DataAnnotations;

    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;

    public class EmailValidator
    {
        private readonly IDeletableEntityRepository<User> user;
        private StringBuilder result;

        public EmailValidator(IDeletableEntityRepository<User> user)
        {
            this.user = user;
            this.result = new StringBuilder();
        }

        public string Validate(string email)
        {
            result.AppendLine(EmailShouldBeValid(email));
            result.AppendLine(EmailShouldBeFree(email));

            return result.ToString();
        }

        public string EmailShouldExistInDb(string email)
        {
            var account = this.user.All().Where(x => x.Email == email).FirstOrDefault();
            if (account == null)
            {
                return "Email doesn't exist";
            }

            return string.Empty;
        }

        private string EmailShouldBeValid(string email)
        {
            var validator = new EmailAddressAttribute();

            return validator.IsValid(email) ? null : "Email should be valid";
        }

        private string EmailShouldBeFree(string email)
        {
            var isFree = (this.user.All().FirstOrDefault(x => x.Email == email)) == null;
            return isFree ? null : "Email already used";
        }
    }
}

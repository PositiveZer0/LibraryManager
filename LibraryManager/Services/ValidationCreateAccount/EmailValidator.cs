namespace LibraryManager.Services.ValidationCreateAccount
{
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;

    public class EmailValidator
    {
        private readonly IDeletableEntityRepository<User> user;
        private string email;
        private StringBuilder result;

        public EmailValidator(IDeletableEntityRepository<User> user, string email)
        {
            this.user = user;
            this.email = email;
            this.result = new StringBuilder();
        }

        public string Validate()
        {
            result.AppendLine(EmailShouldBeValid());
            result.AppendLine(EmailShouldBeFree());

            return result.ToString();
        }

        private string EmailShouldBeValid()
        {
            var validator = new EmailAddressAttribute();

            return validator.IsValid(this.email) ? null : "Email should be valid";
        }

        private string EmailShouldBeFree()
        {
            var isFree = (this.user.All().FirstOrDefault(x => x.Email == email)) == null;
            return isFree ? null : "Email already used";
        }
    }
}

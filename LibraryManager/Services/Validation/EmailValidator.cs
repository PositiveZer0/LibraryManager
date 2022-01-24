namespace LibraryManager.Services.Validation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class EmailValidator
    {
        private string email;
        private StringBuilder result;

        public EmailValidator(string email)
        {
            this.email = email;
            this.result = new StringBuilder();
        }

        public string Validate()
        {
            result.AppendLine(EmailShouldBeValid());

            return result.ToString();
        }

        private string EmailShouldBeValid()
        {
            var validator = new EmailAddressAttribute();

            return validator.IsValid(this.email) ? null : "Email should be valid";
        }
    }
}

namespace LibraryManager.Services.Login.ValidationCreateAccount
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using LibraryManager.SendGrid;
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;

    public class SixDigitCodeValidator : ISixDigitCodeValidator
    {
        private IDeletableEntityRepository<ConfirmEmail> confirmEmail;
        private readonly IDeletableEntityRepository<User> user;
        Random code;

        public SixDigitCodeValidator(IDeletableEntityRepository<ConfirmEmail> confirmEmail,
            IDeletableEntityRepository<User> user)
        {
            this.confirmEmail = confirmEmail;
            this.user = user;
            code = new Random();
        }

        public async Task GenerateAsync(string email)
        {
            var userId = this.user.All().Where(x => x.Email == email).FirstOrDefault().Id;

            var confirmation = new ConfirmEmail
            {
                ConfirmationCode = this.code.Next(100000, 999999).ToString(),
                UserId = userId,
            };

            await this.confirmEmail.AddAsync(confirmation);
            await this.confirmEmail.SaveChangesAsync();

            await SendEmailAsync(email, confirmation.ConfirmationCode);
        }

        public async Task ResendCode(string email)
        {
            var deletedConfirmEmail = GetClient(email);
            this.confirmEmail.Delete(deletedConfirmEmail);

            await GenerateAsync(email);
        }

        public bool IsValid(string email, string code)
        {
            var client = GetClient(email);

            return client.ConfirmationCode == code;
        }

        public async Task ValidateAsync(string email)
        {
            var client = this.confirmEmail.All().Select(x => new {
                x.UserId,
                x.User,
            }).Where(x => x.User.Email == email).FirstOrDefault();
            client.User.IsEmailVerified = true;

            var deletedConfirmEmail = GetClient(email);
            this.confirmEmail.Delete(deletedConfirmEmail);
            await this.confirmEmail.SaveChangesAsync();
        }

        private ConfirmEmail GetClient(string email)
        {
            return this.confirmEmail.All().Where(x => x.User.Email == email).FirstOrDefault();
        }

        private async Task SendEmailAsync(string email, string code)
        {
            var sendGrid = new SendGridEmailSender(ConfigurationConstants.SENDGRID_APIKEY);
            //sender, sender name, receiver
            await sendGrid.SendEmailAsync("azsumemi@gmail.com", "Library Manager", email, "Code verification", code);
        }

    }
}

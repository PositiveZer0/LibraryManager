namespace LibraryManager.Services.ValidationCreateAccount
{
    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    using LibraryManager.SendGrid;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SixDigitCodeValidator
    {
        private IDeletableEntityRepository<ConfirmEmail> confirmEmail;
        private readonly IDeletableEntityRepository<User> user;

        public SixDigitCodeValidator(IDeletableEntityRepository<ConfirmEmail> confirmEmail,
            IDeletableEntityRepository<User> user)
        {
            this.confirmEmail = confirmEmail;
            this.user = user;
        }

        public async Task Generate(string email)
        {
            var userId = this.user.All().Where(x => x.Email == email).FirstOrDefault().Id;

            var confirmation = new ConfirmEmail
            {
                ConfirmationCode = "123456",
                UserId = userId,
            };

            await this.confirmEmail.AddAsync(confirmation);
            await this.confirmEmail.SaveChangesAsync();

            SendEmail(email, confirmation.ConfirmationCode);
        }

        public bool IsValid(string email, string code)
        {
            var client = GetClient(email);

            return client.ConfirmationCode == code;
        }

        public void Validate(string email)
        {
            var client = this.confirmEmail.All().Select(x => new { 
                x.UserId,
                x.User,
            }).Where(x => x.User.Email == email).FirstOrDefault();
            client.User.IsEmailVerified = true;

            var deletedConfirmEmail = GetClient(email);
            this.confirmEmail.Delete(deletedConfirmEmail);
            this.confirmEmail.SaveChangesAsync();
        }

        private ConfirmEmail GetClient(string email)
        {
            return this.confirmEmail.All().Where(x => x.User.Email == email).FirstOrDefault();
        }

        private  void SendEmail(string email, string code)
        {
            var sendGrid = new SendGridEmailSender(ConfigurationConstants.SENDGRID_APIKEY);
            //sender, sender name, receiver
            //todo: add email
            sendGrid.SendEmailAsync("azsumemi@gmail.com", "Library Manager", "ghostinthewires@abv.bg", "Code verification", code);
        }

    }
}

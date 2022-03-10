namespace LibraryManager.Services.Admin
{
    using System.Linq;
    using System.Threading.Tasks;

    using LibraryManager.Database.Models;
    using LibraryManager.Database.Repositories;
    
    public class AdminService : IAdminService
    {
        private IDeletableEntityRepository<Book> book;
        public AdminService(IDeletableEntityRepository<Book> book)
        {
            this.book = book;
        }

        public async Task UpdateBookAsync(Book book, int id)
        {
            var currentBook = this.GetBookById(id);
            currentBook.Title = book.Title;
            currentBook.AuthorName = book.AuthorName;
            currentBook.Genre = book.Genre;
            currentBook.Quantity = book.Quantity;
            currentBook.Description = book.Description;
            await this.book.SaveChangesAsync();
        }

        public Book GetBookById(int id)
        {
            return this.book.All().FirstOrDefault(x => x.Id == id);
        }
    }
}

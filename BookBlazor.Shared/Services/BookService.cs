using BookBlazorServer.Data;
using BookBlazorServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookBlazorServer.Services
{
    public class BookService : IBookService
    {
        private readonly DataContext dataContext;

        public BookService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            dataContext.Books.Add(book);
            await dataContext.SaveChangesAsync();
            return book;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            await Task.Delay(2000);
            return await dataContext.Books.ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await dataContext.Books.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Book> UpdateBook(Book book)
        {
            var b = await dataContext.Books.FirstOrDefaultAsync(x=>x.Id==book.Id);
            b.Name = book.Name;
            dataContext.SaveChanges();
            return b;
        }
    }
}

using BookBlazorServer.Entities;

namespace BookBlazorServer.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooksAsync();

        Task<Book> AddBookAsync(Book book);

        Task<Book> GetBookById(int id);

        Task<Book> UpdateBook(Book book);
    }
}

using BookBlazorServer.Entities;
using BookBlazorServer.Services;
using System.Net.Http.Json;

namespace BookBlazorServer.Client
{
    public class ClientBookService : IBookService
    {
        private readonly HttpClient httpClient;

        public ClientBookService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            var response = await httpClient.PostAsJsonAsync("/api/book", book);
            return await response.Content.ReadFromJsonAsync<Book>();
        }

        public Task<List<Book>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetBookById(int id)
        {
            var response = await httpClient.GetAsync($"/api/book/{id}");
            return await response.Content.ReadFromJsonAsync<Book>();
        }
        public async Task<Book> UpdateBook(Book book)
        {
            var response = await httpClient.PutAsJsonAsync("/api/book", book);
            return await response.Content.ReadFromJsonAsync<Book>();
        }
    }
}

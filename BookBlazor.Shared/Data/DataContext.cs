using BookBlazorServer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookBlazorServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}

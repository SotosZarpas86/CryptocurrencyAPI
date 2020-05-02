using CryptoCurrencyAPI.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace CryptoCurrencyAPI.DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cryptocurrency> Cryptocurrencies { get; set; }
    }
}

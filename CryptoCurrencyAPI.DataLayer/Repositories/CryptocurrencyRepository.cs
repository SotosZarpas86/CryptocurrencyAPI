using CryptoCurrencyAPI.DataLayer.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCurrencyAPI.DataLayer.Repositories
{
    public class CryptocurrencyRepository : ICryptocurrencyRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private static string _connectionString;

        public CryptocurrencyRepository(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DBConnection");
        }

        public async Task<Cryptocurrency> GetByNameAsync(string name)
        {
            var query = @"SELECT * FROM [dbo].[Cryptocurrencies] WHERE Name=@Name";
            using var connection = new SqlConnection(_connectionString);
            return await connection.QuerySingleOrDefaultAsync<Cryptocurrency>(query, new { Name = name });
        }

        public async Task InsertAsync(Cryptocurrency cryptocurrency)
        {
            if(cryptocurrency.Id == Guid.Empty) cryptocurrency.Id = Guid.NewGuid();
            var dbRow = await _context.Cryptocurrencies.FirstOrDefaultAsync(c => c.Id == cryptocurrency.Id);
            if (dbRow != null) throw new Exception("There is already a record with the provided Id");           
           
            await _context.Cryptocurrencies.AddAsync(cryptocurrency);
            await _context.SaveChangesAsync();
        }
    }
}

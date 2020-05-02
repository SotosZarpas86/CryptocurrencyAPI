using CryptoCurrencyAPI.DataLayer.Entities;
using System.Threading.Tasks;

namespace CryptoCurrencyAPI.DataLayer.Repositories
{
    public interface ICryptocurrencyRepository
    {
        Task<Cryptocurrency> GetByNameAsync(string name);
        Task InsertAsync(Cryptocurrency cryptocurrency);
    }
}
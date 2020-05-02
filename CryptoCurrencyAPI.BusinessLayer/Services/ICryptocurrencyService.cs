using CryptoCurrencyAPI.BusinessLayer.Models;
using System.Threading.Tasks;

namespace CryptoCurrencyAPI.BusinessLayer.Services
{
    public interface ICryptocurrencyService
    {
        Task<CryptocurrencyModel> GetByNameAsync(string name);
        Task InsertAsync(CryptocurrencyModel cryptocurrency);
    }
}
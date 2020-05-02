using AutoMapper;
using CryptoCurrencyAPI.BusinessLayer.Models;
using CryptoCurrencyAPI.DataLayer.Entities;
using CryptoCurrencyAPI.DataLayer.Repositories;
using System.Threading.Tasks;

namespace CryptoCurrencyAPI.BusinessLayer.Services
{
    public class CryptocurrencyService : ICryptocurrencyService
    {
        private readonly ICryptocurrencyRepository _cryptocurrencyRepository;
        private readonly IMapper _mapper;

        public CryptocurrencyService(ICryptocurrencyRepository cryptocurrencyRepository, IMapper mapper)
        {
            _cryptocurrencyRepository = cryptocurrencyRepository;
            _mapper = mapper;
        }

        public async Task<CryptocurrencyModel> GetByNameAsync(string name)
        {
            var cryptocurrency = await _cryptocurrencyRepository.GetByNameAsync(name);
            return _mapper.Map<CryptocurrencyModel>(cryptocurrency);
        }

        public async Task InsertAsync(CryptocurrencyModel cryptocurrency)
        {
            var cryptocurrencyEntity = _mapper.Map<Cryptocurrency>(cryptocurrency);
            await _cryptocurrencyRepository.InsertAsync(cryptocurrencyEntity);
        }
    }
}

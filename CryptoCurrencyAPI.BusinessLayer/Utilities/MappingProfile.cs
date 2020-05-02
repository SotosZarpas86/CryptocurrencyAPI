using AutoMapper;
using CryptoCurrencyAPI.BusinessLayer.Models;
using CryptoCurrencyAPI.DataLayer.Entities;

namespace CryptoCurrencyAPI.BusinessLayer.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CryptocurrencyModel, Cryptocurrency>().ReverseMap();
        }
    }
}
